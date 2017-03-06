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
        private List<PictureBox> pictureboxen = new List<PictureBox>();
        private List<Label> labels = new List<Label>();
        EditActor kiesnaam;
        EditProperties UseCaseProps;
        EditProperties editUseCaseProps;
        Point actorlijn;
        Point usecaselijn;
        bool inlijn = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Point a = PointToClient(MousePosition);
            a.X = a.X - 12;
            a.Y = a.Y - 100;
            if (rabActor.Checked && rabAdd.Checked)
            {
                
                kiesnaam = new EditActor(a);
                kiesnaam.Show();
                kiesnaam.VisibleChanged += kiesnaamVisibleChanged;
                
            }
            if(rabUseCase.Checked && rabAdd.Checked)
            {
                UseCaseProps = new EditProperties(a);
                UseCaseProps.Show();
                UseCaseProps.VisibleChanged += UseCasePropsVisibleChanged;
            }
            if (rabLine.Checked && inlijn == true)
            {
                inlijn = false;
                usecaselijn = a;
                lines.Add(new Line(actorlijn, usecaselijn));
                this.Refresh();
            }
            else if (rabLine.Checked && inlijn == false)
            {
                inlijn = true;
                actorlijn = a;
            }

        }
        private void UseCasePropsVisibleChanged(object sender, EventArgs e)
        {
            UseCase a = new UseCase(UseCaseProps.naam, UseCaseProps.Samenvatting, UseCaseProps.Actoren, UseCaseProps.Aannamen, UseCaseProps.Beschrijving, UseCaseProps.Uitzonderingen, UseCaseProps.Resultaat, UseCaseProps.plaats);
            usecases.Add(a);
            UseCaseProps.Close();
            loadAllItems();
        }
        private void kiesnaamVisibleChanged(object sender, EventArgs e)
        {
            Actor a = new Actor(kiesnaam.actorNaam, kiesnaam.clicklocatie);
            actors.Add(a);
            loadAllItems();
        }
        private void loadAllItems()
        {
            foreach(PictureBox a in pictureboxen)
            {
                a.Dispose();
            }
            foreach(Label a in labels)
            {
                a.Dispose();
            }
            foreach(UseCase a in usecases)
            {
                PictureBox pb = new PictureBox();
                a.dezepicturebox = pb;
                pb.Width = 120;
                pb.Height = 30;
                pb.Location = a.plaats;
                pb.ImageLocation = (@"C:\Users\777beer\Source\Repos\usecasetest\usecases\usecases\afbeeldingen\ellipse.jpg");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.MouseClick += Pb_MouseClick;
                Label lb = new Label();
                Point labelplaats = a.plaats;
                labelplaats.Y = labelplaats.Y + 05;
                labelplaats.X = labelplaats.X + 45;
                lb.Text = a.naam;
                lb.Location = labelplaats;
                canvas.Controls.Add(lb);
                canvas.Controls.Add(pb);
                pictureboxen.Add(pb);
                labels.Add(lb);
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
                pictureboxen.Add(pb);
                labels.Add(lb);
            }
        }

        private void Pb_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (rabSelect.Checked)
            {
                UseCase gevonden = null;
                foreach(UseCase a in usecases)
                {
                    if(a.dezepicturebox == sender)
                    {
                        gevonden = a;
                    }
                }
                editUseCaseProps = new EditProperties(gevonden);
                editUseCaseProps.Show();
                usecases.Remove(gevonden);
                editUseCaseProps.VisibleChanged += EditUseCaseProps_VisibleChanged;
                MessageBox.Show(sender.ToString());
            }
            else if (rabDelete.Checked)
            {
                UseCase gevonden = null;
                foreach (UseCase a in usecases)
                {
                    if (a.dezepicturebox == sender)
                    {
                        gevonden = a;
                    }
                }
                usecases.Remove(gevonden);
                loadAllItems();
            }
        }

        private void EditUseCaseProps_VisibleChanged(object sender, EventArgs e)
        {
            UseCase a = new UseCase(editUseCaseProps.naam, editUseCaseProps.Samenvatting, editUseCaseProps.Actoren, editUseCaseProps.Aannamen, editUseCaseProps.Beschrijving, editUseCaseProps.Uitzonderingen, editUseCaseProps.Resultaat, editUseCaseProps.plaats);
            usecases.Add(a);
            editUseCaseProps.Close();
            loadAllItems();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

            foreach (Line a in lines)
            {
                Graphics g = e.Graphics;
                Pen enigepen = new Pen(Color.Red, 3);
                g.DrawLine(enigepen, a.beginpunt, a.eindpunt);
            }
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRLines_Click(object sender, EventArgs e)
        {
            lines.Clear();
            Refresh();
        }
    }
}
