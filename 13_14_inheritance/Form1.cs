using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;


        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");

        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                fMoving(-30);
            }
            else if(e.KeyCode == Keys.W)
            {
                fMoving(30);
            }
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fOneCycleDraw();            
        }
        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCarDraw();
        }        

        /// <summary>
        /// 각 Part 대한 위치 그림을 그려준다
        /// </summary>
        private void fOneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPeninfo();
            
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }
        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPeninfo();

            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }
        private void fCarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.fPeninfo();

            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }

        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fMoving(-10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fMoving(10);
        }

        private void fMoving(int iMove)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(iMove);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(iMove);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(iMove);
                    fCarDraw();
                    break;
            }
        }


}
}
