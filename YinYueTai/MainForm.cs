﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayeredSkin.Forms;
namespace YinYueTai
{
    public partial class MainForm : LayeredForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string cUrl = "http://112.253.22.159/26/g/y/b/g/gybgsjmefinvgmtgorihtjcurdvsxb/hd.yinyuetai.com/E7B0015CEA430A24FB11D8EC416E4349.mp4";
            //axPlayer.Open(cUrl);
            //axPlayer.SetVolume(10);
            //axPlayer.Play();
        }

        private void axPlayer_OnMessage(object sender, AxAPlayer3Lib._IPlayerEvents_OnMessageEvent e)
        {

        }
    }
}
