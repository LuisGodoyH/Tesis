using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        private Capture captura;
        private bool capturaenProgreso;
        private HaarCascade hcasdade;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        private int tamañoventana = 25;
        private Double IncrementalScala = 1.1;
        private int Minde = 3;
        Image<Bgr, Byte> ImagenFrame;
        string name, names = null;
        Image<Gray, byte> result, TrainedFace = null;
        Bitmap[] extrostro;
        int rostrono = 0;
        Capture grabber;
        Image<Gray, byte> gray = null;
        Image<Bgr, Byte> currentFrame;
        int ContTrain, NumLabels, t;
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        public Form1()
        {
            InitializeComponent();
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("No cargo las imagenes).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Procesoframe(object sender, EventArgs arg)
        {
            ImagenFrame = captura.QueryFrame();
            camImagen.Image = ImagenFrame;

        }
        private void ReleaseData()
        {
            if (captura != null)
                captura.Dispose();
        }
        private void Agregarrostro()
        {
            try
            {
                Minde = int.Parse(cmbminimo.Text);
                tamañoventana = int.Parse(txtdetectmin.Text);
                IncrementalScala = Double.Parse(cmbescala.Text);
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = captura.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                hcasdade,
                IncrementalScala,
                Minde,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                ////trainingImages.Add(TrainedFace);
                //labels.Add(textBox1.Text);

                //Show face added in gray scale
                pbExtraerRostro.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                //File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                ////Write the labels of triained faces in a file text for further load
                //for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                //{
                //    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                //    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                //    objentimagen.Nombre = textBox1.Text;
                //    objentimagen.Ruta = Application.StartupPath + "/TrainedFaces/face" + i + ".bmp";
                //    objimagen.ingresar_imagen(objentimagen);
                //}

                //MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DetectarRostros3()
        {
            try
            {
                Image<Gray, Byte> gFrame = ImagenFrame.Convert<Gray, Byte>();
                Minde = int.Parse(cmbminimo.Text);
                tamañoventana = int.Parse(txtdetectmin.Text);
                IncrementalScala = Double.Parse(cmbescala.Text);
                //Get the current frame form capture device
                currentFrame = captura.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Convert it to Grayscale
                gray = currentFrame.Convert<Gray, Byte>();
                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                hcasdade,
                IncrementalScala,
                Minde,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    //t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                   
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                                      
               }
                //t = 0;

                
                camImagen.Image = currentFrame;
              




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

       
        private void btniniciar_Click_1(object sender, EventArgs e)
        {
           
            if (captura != null)
            {
                if (btniniciar.Text == "Dectando Rostros")
                {
                    btniniciar.Text = "Iniciar";
                    Application.Idle -= Procesoframe;
                    DetectarRostros3();
                    Agregarrostro();
                }

                else
                {
                    btniniciar.Text = "Dectando Rostros";
                    Application.Idle += Procesoframe;
                }
            }
        }

        private void cmbcamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Numerocamaras = -1;
            Numerocamaras = int.Parse(cmbcamara.Text);
            #region
            if (captura == null)
            {
                try
                {
                    captura = new Capture(Numerocamaras);
                }
                catch (NullReferenceException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            #endregion 
            btniniciar_Click_1(sender, e);
            btniniciar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hcasdade = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }

        
        private void btncargar_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image ingresarImagen = Image.FromFile(this.openFileDialog1.FileName);
                ImagenFrame = new Image<Bgr, byte>(new Bitmap(ingresarImagen));
                camImagen.Image = ImagenFrame;
                //DetectarRostros();
            }
           
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (rostrono < extrostro.Length - 1)
            {
                rostrono++;
                
            }
            else
            {
                MessageBox.Show("no hay mas imagenes");
            }
        }

        private void btnantes_Click(object sender, EventArgs e)
        {
            if (rostrono > 0)
            {
                rostrono--;
                
            }
            else
            {
                MessageBox.Show("la primera imagen");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            trainingImages.Add(TrainedFace);
            labels.Add(txtnombre.Text);

            

            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
        }

        
        void FrameGrabber(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();
            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
            hcasdade,
            1.2,
            10,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));
            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
              {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);

                    

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();

               
            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBox1.Image = currentFrame;
            label4.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Gray, Byte> gFrame = ImagenFrame.Convert<Gray, Byte>();
                Minde = int.Parse(cmbminimo.Text);
                tamañoventana = int.Parse(txtdetectmin.Text);
                IncrementalScala = Double.Parse(cmbescala.Text);
                NamePersons.Add("");
                //Get the current frame form capture device
                currentFrame = captura.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Convert it to Grayscale
                gray = currentFrame.Convert<Gray, Byte>();
                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                hcasdade,
                IncrementalScala,
                Minde,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                    
                    if (trainingImages.ToArray().Length != 0)
                    {
                        //TermCriteria for face recognition with numbers of trained images like maxIteration
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Eigen face recognizer
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                           trainingImages.ToArray(),
                           labels.ToArray(),
                           3000,
                           ref termCrit);

                        name = recognizer.Recognize(result);

                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                    }

                    NamePersons[t - 1] = name;
                    NamePersons.Add("");

                }
                t = 0;

                
                for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                {
                    names = names + NamePersons[nnn] + ", ";
                }
                
                imageBox1.Image = currentFrame;
                // label4.Text = names;
                //names = "";
                //Clear the list(vector) of names
                NamePersons.Clear();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
