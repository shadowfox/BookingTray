using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingTray
{
    public partial class BookingTray : Form
    {
        private static ContextMenu trayMenu;
        private static NotifyIcon trayIcon;

        public BookingTray()
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Booking Tray";
            trayIcon.Icon = TrayIcon.GetIcon("5");
            trayIcon.Visible = true;
            trayIcon.ContextMenu = trayMenu;
        }

        protected override void OnLoad(EventArgs e)
        {
            // We don't want the application itself to be visible anywhere
            Visible = false;
            ShowInTaskbar = false;

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="isDisposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                trayIcon.Dispose();

                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(isDisposing);
        }
    }
}
