using System;
using System.Windows.Forms;

/* How to do?
 * Create at Form1 Designer panel with some Buttons as Menu
 * Place a panel next to and set dockingstyle = fill
 * Go to menu -> project -> UserControll add to create some Pages
 */

namespace MultiWindowMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            setTrigger(); //setting up triggers
            showContent(new PageDefault()); // setting up default page
        }

        /*
         * setTrigger
         * setting up the trigger handling
         * button click method isnt neccessary
        */
        private void setTrigger()
        {
            btnPage1.Click += (s, e) => showContent(new PageOne()); // click event handler from btnPage1 - open method showContent(Usercontroll PageOne)
            btnPage2.Click += (s, e) => showContent(new PageTwo());// click event handler from btnPage2 - open method showContent(Usercontroll PageTwo)
            menuStripPageToolStripMenuItem.Click += (s, e) => showContent(new PageDefault());// click event handler from Menustrip - open method showContent(Usercontroll PageDefault)
        }

        /*
         * showContent
         * setting up the Page logic
         * Params UserControll Object
        */
        private void showContent(UserControl contentPage)
        {
            contentPanel.Controls.Clear(); // clearing up the previous content page
            contentPage.Dock = DockStyle.Fill; // changing dockstyle from new content page to FILL
            contentPanel.Controls.Add(contentPage); // adding new content page to contentPanel
        }

        /*
         * btnClose Method
         * close the application
        */
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
