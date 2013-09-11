using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Deployment;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using SharpPcap;
using PacketDotNet;
using System.IO;
using System.Diagnostics;
using PacketDotNet.Utils;

namespace PortAuthority
{

    public partial class PortAuthorityMain : Form
    {
        public PortAuthorityMain()
        {
            InitializeComponent();
        }

        //returns the updated currently selected network interface and updates MAC and IP accordingly
        private NetworkInterface refreshMacAndIP()
        {
            string id = ((NetworkInterface)InterfaceBox.SelectedItem).Id;
            NetworkInterface sni = null;
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Id == id)
                {
                    sni = ni;
                    break;
                }
            }
            MacText.Text = BitConverter.ToString(sni.GetPhysicalAddress().GetAddressBytes()).Replace('-', ':');
            IpText.Text = "0.0.0.0";
            foreach (UnicastIPAddressInformation ip in sni.GetIPProperties().UnicastAddresses)
            {
                //if valid ipv4 address
                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IpText.Text = ip.Address.ToString();
                }
            }
            if (sni == null)
            {
                MapButton.Enabled = false;
            }
            return sni;
        }

        private void PortAuthorityMain_Load(object sender, EventArgs e)
        {
            MsgText.Text = "Initializing...";

            //Version Check
            try
            {
                CurrentVersionText.Text = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                CurrentVersionText.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                MsgText.Text = "Warning: Application not published";
            }
            NewestVersionText.Text = "Unknown"; //Not Urgent: Maybe I'll put some version checking later
            ProgressBar.Increment(30);

            //Generation of drop down menu for network interfaces
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                InterfaceBox.Items.Add(ni);
            }
            ProgressBar.Increment(70);
            MsgText.Text = "";
            ProgressBar.Value = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CurrentVersionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewestVersionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MsgText.Text = "This link is not yet implemented";
            NewestVersionText.Text = "Unknown";
        }

        private void InterfaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMacAndIP();
            MapButton.Enabled = true;
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            //Check Input
            if ((UserText.Text=="")||(PassText.Text=="")||(RoomText.Text=="")||(JackText.Text==""))
            {
                MsgText.Text = "Please fill out all the fields before proceeding";
                return;
            }

            ProgressBar.Increment(10);
            //Refresh IP
            NetworkInterface sni;
            sni = refreshMacAndIP();
            if (sni.OperationalStatus != OperationalStatus.Up)
            {
                MsgText.Text =  "The selected network interface is not up. Check your connection.";
                return;
            }
            if (IpText.Text.StartsWith("169.254.") || IpText.Text.Equals("0.0.0.0"))
            {
                MsgText.Text = "Unable to obtain a valid IP address. Try again.";
                return;
            }
            ProgressBar.Increment(25);
            MsgText.Text = "Mapping...";
            this.Refresh();
            //Declare variables
            WebRequest req;
            WebResponse resp;
            Stream dstream;
            StreamReader reader;
            ICaptureDevice idev = null;
            Packet packet;
            LLDPPacket lldp;
            RawCapture rawpacket;
            string data;
            string query = "https://netcenter.studentaffairs.ohio-state.edu/portmapper/port_authority.php";
            string switchname;
            string portnumber;
            bool gig = false;

            //Set up selected network device
            bool matched = false;
            foreach (ICaptureDevice icd in CaptureDeviceList.Instance)
            {
                icd.Open(DeviceMode.Promiscuous,4000);
                if (BitConverter.ToString(icd.MacAddress.GetAddressBytes()).Replace('-', ':') == MacText.Text)
                {
                    idev = icd;
                    matched = true;
                    break;
                }
                icd.Close();
            }
            if (!matched)
            {
                MsgText.Text = "Unable to match selected network adapter to ICaptureDevice";
                return;
            }
            idev.Filter = "ether dst 01:80:c2:00:00:0e";

            ProgressBar.Increment(10);
            //Begin capturing packets, search for LLDP packet
            rawpacket = idev.GetNextPacket();
            idev.Close();
            if (rawpacket == null)
            {
                MsgText.Text = "Unable to capture packet: Check the connection and try again";
                return;
            }
            packet = Packet.ParsePacket(rawpacket.LinkLayerType, rawpacket.Data);
            lldp = (LLDPPacket)packet.Extract(typeof(LLDPPacket));
           //Function LLDPPacket.GetEncapsulated() is obsolete
            //lldp = LLDPPacket.GetEncapsulated(Packet.ParsePacket(rawpacket.LinkLayerType, rawpacket.Data));
            if (lldp == null)
            {
                MsgText.Text = "Unable to parse packet: Try again";
                return;
            }

            ProgressBar.Increment(35);
            //Decipher LLDP packet
            //Debug.WriteLine(BitConverter.ToString(lldp[3].Bytes));
            //Debug.WriteLine(BitConverter.ToString(lldp[6].Bytes));
            switchname = Encoding.UTF8.GetString(lldp[3].Bytes);
            switchname = switchname.Substring(2);
            portnumber = Encoding.UTF8.GetString(lldp[6].Bytes);
            portnumber = portnumber.Substring(2);
            if (portnumber[0] == 'g' || portnumber[0] == 'G')
                gig = true;
            portnumber = portnumber.Split('/')[2];
            //Formatting so compatible with port_authority.php
            
            //Debug.WriteLine(switchname);
            //Debug.WriteLine(portnumber);

            //Create query string
            /*
            data = new NameValueCollection();
            data["roomnumber"] = RoomText.Text;
            data["jack"] = JackText.Text;
            data["deviceid"] = switchname;
            data["portid"] = portnumber;
            data["user"] = UserText.Text;
            data["pass"] = PassText.Text;
            */
            //Debug.WriteLine(data.ToString());
            data = "roomnumber=" + RoomText.Text +
            "&jack=" + JackText.Text +
            "&deviceid=" + switchname +
            "&portid=" + portnumber +
            "&gigabit=" + (gig?"1":"0") +
            "&user=" + UserText.Text +
            "&pass=" + PassText.Text;
            byte[] postData = Encoding.UTF8.GetBytes(data.ToString());

            ProgressBar.Increment(10);
            //Webrequest stuff
            MsgText.Text = "Connecting to Netcenter...";
            this.Refresh();
            try
            {
                req = WebRequest.Create(query);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = postData.Length;
                dstream = req.GetRequestStream();
                dstream.Write(postData, 0, postData.Length);
                dstream.Close();

                resp = req.GetResponse();
                dstream = resp.GetResponseStream();
                reader = new StreamReader(dstream);
                MsgText.Text = reader.ReadToEnd();
                ProgressBar.Increment(10);

                reader.Close();
                dstream.Close();
                resp.Close();
            }
            catch (WebException we)
            {
                MsgText.Text = we.Message;
            }
            finally
            {
                ProgressBar.Value = 0;
            }
        }
    }
}
