using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usecases
{
    public partial class Form1 : Form
    {
        private List<UseCase> usecases = new List<UseCase>();
        private List<Line> lines = new List<Line>();
        private List<Actor> actors = new List<Actor>();
        private List<PictureBox> actoren = new List<PictureBox>();
        private List<Label> actorlabels = new List<Label>();
        EditActor kiesnaam;
        EditProperties UseCaseProps;
        public Form1()
        {
            InitializeComponent();

        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Point a = PointToClient(MousePosition);
            a.X = a.X - 12;
            a.Y = a.Y - 124;
            if (rabActor.Checked && rabAdd.Checked)
            {
                
                kiesnaam = new EditActor(a);
                kiesnaam.Show();
                kiesnaam.VisibleChanged += kiesnaamVisibleChanged;
                
            }
            if(rabUseCase.Checked && rabAdd.Checked)
            {
                UseCaseProps = new EditProperties();
                UseCaseProps.Show();
                UseCaseProps.VisibleChanged += UseCasePropsVisibleChanged;
            }
        }
        private void UseCasePropsVisibleChanged(object sender, EventArgs e)
        {

        }
        private void kiesnaamVisibleChanged(object sender, EventArgs e)
        {
            Actor a = new Actor(kiesnaam.actorNaam, kiesnaam.clicklocatie);
            actors.Add(a);
            loadAllItems();
        }
        private void loadAllItems()
        {
            foreach(PictureBox a in actoren)
            {
                a.Dispose();
            }
            foreach(Label a in actorlabels)
            {
                a.Dispose();
            }
            foreach(Actor a in actors)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 40;
                pb.Height = 60;
                pb.Location = a.plaats;
                pb.ImageLocation = (@"C:\Users\777beer\Source\Repos\usecasetest\usecases\usecases\afbeeldingen\8537.png");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                Label lb = new Label();
                Point labelplaats = a.plaats;
                labelplaats.Y = labelplaats.Y + 60;
                lb.Text = a.name;
                lb.Location = labelplaats;
                canvas.Controls.Add(lb);
                canvas.Controls.Add(pb);
                actoren.Add(pb);
                actorlabels.Add(lb);
            }
            //PictureBox pb = new PictureBox();
            //pb.Width = 40;
            //pb.Height = 60;
            //pb.Location = PointToClient(MousePosition);
            //Point a = pb.Location;
            //a.X = a.X - 12;
            //a.Y = a.Y - 124;
            //pb.Location = a;
            //pb.ImageLocation = (@"C:\Users\777beer\Source\Repos\usecasetest\usecases\usecases\afbeeldingen\8537.png");
            //pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //canvas.Controls.Add(pb);
        }
    }
}
