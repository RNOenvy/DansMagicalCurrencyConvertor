﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DansMagicalCurrencyConvertor
{
    public partial class currencyConvert : Form
    {
        public currencyConvert()
        {
            InitializeComponent();
        }

                     private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Navigate("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

        }
    }
}
