using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 兩院比對EMR.Controller;
using 兩院比對EMR.Model;
using 兩院比對EMR.Repository;

namespace 兩院比對EMR
{
    public partial class frmManager : Form
    {
        private ManagerController controller;        
        public btnstate Btnstate;
        public Action CRUD;
        public frmManager(IRepositoryWrapper repository)
        {
            InitializeComponent();
            Load();
            controller = new ManagerController(repository);            
            btnEdit.Click += delegate { componentState(btnstate.edit); };
            btnCancel.Click += delegate { componentState(btnstate.cancel); };
            btnSave.Click += delegate {doCRUD(); componentState(btnstate.cancel); };

        }
        private void Load()
        {
            TB_Mainhost.Text= Settings.Mainhost.hostname; 
            TB_Mainpath.Text=Settings.Mainhost.path    ;
            TB_Awayhost.Text=Settings.Awayhost.hostname;
            TB_Awaypath.Text=Settings.Awayhost.path;
        }
        public void componentState(btnstate state)
        {
           
            btnEdit.Checked = false;
            switch (state)
            {
               
                case btnstate.edit:
                    btnEdit.Checked = true;
                    TB_Mainhost.Enabled = true;
                    TB_Mainpath.Enabled = true;
                    TB_Awayhost.Enabled = true;
                    TB_Awaypath.Enabled = true;
                    break;
               
                case btnstate.cancel:                   
                    btnEdit.Checked = false;
                    TB_Mainhost.Enabled = false;
                    TB_Mainpath.Enabled = false;
                    TB_Awayhost.Enabled = false;
                    TB_Awaypath.Enabled = false;
                    break;

                default:
                    break;
                   
            }
            Actionstate(state);
        }
        public void Actionstate(btnstate state)
        {           
                switch (state)
                {
                    case btnstate.edit:
                        btnSave.Enabled = true;
                        CRUD = new Action(controller.Update);
                        break;                    
                    case btnstate.cancel:
                        btnSave.Enabled = false;
                        break;
                    default:
                        break;
                }
        }
        public void doCRUD()
        {
            Settings.Mainhost.hostname = TB_Mainhost.Text;
            Settings.Mainhost.path = TB_Mainpath.Text;
            Settings.Awayhost.hostname = TB_Awayhost.Text;
            Settings.Awayhost.path = TB_Awaypath.Text;
            CRUD();
        }
        public enum btnstate
        {
            creat,edit,delete,cancel
        }
    }
}
