using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrownianMotion
{
    public partial class Form1 : Form
    {
        List<Molecule> molecules;
        int speed;
        Task mainTask;
        CancellationTokenSource cancelToken;
        CancellationToken ct;
        public Form1()
        {
            InitializeComponent();
            this.molecules = new List<Molecule>();
        }

        public void reload()
        {
            this.molecules.Clear();
            for (int i = 0; i < this.numberField.Value; i++)
            {
                var molecule = new Molecule(i);
                this.molecules.Add(molecule);
                molecule.update(this.drawBox);
            }
            cancelToken = new CancellationTokenSource();
            ct = cancelToken.Token;
            this.updateAll();
        }

        public void runMotion(int i)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var rnd = new Random(i);
                int spd = rnd.Next((int)(speed * 0.8), (int)(speed));
                while (true)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }
                    this.molecules[i].update(this.drawBox);
                    Thread.Sleep(1000 - spd);
                }
            }, ct);
        }

        public void updateAll()
        {
            for (int i = 0; i < this.molecules.Count; i++)
            {
                runMotion(i);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var graphics = this.drawBox.CreateGraphics();
            if (this.cancelToken != null)
            {
                this.cancelToken.Cancel();
            }
            graphics.Clear(Color.White);
            this.reload();
        }

        private void temperatureInput_ValueChanged(object sender, EventArgs e)
        {
            this.speed = this.temperatureInput.Value - 1;
        }
    }
}
