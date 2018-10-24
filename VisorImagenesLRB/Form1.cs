using System;
using System.Drawing;
using System.Windows.Forms;
using Visor;
using System.Collections;

namespace VisorImagenesLRB
{
    public partial class Form1 : Form
    {
        
        int profundidadZoom = 0;
        Point offset;
        Boolean arrastre = false;
        VisorFoto VF = new VisorFoto(700,500);
        ToolTip tt = new ToolTip();
        ArrayList listaNombres = new ArrayList();


        public Form1()
        {
            InitializeComponent();
            this.Focus();
            this.panelPicture.MouseWheel += img_Principal_MouseWheel;
        }

/*Load Image*/		
        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            fd_Abrir.ShowDialog();                    
            try
            {
                foreach(String foto in fd_Abrir.FileNames) 
                {
                    VF.Agregar_Foto((Bitmap)Bitmap.FromFile(foto));  //saving bitmaps from root file into VF object.

                    listaNombres.Add(formatearRaiz(foto)); //Trimming filenames and saving the name
                }
					
                img_Principal.Image = VF.Foto_Actual(); //set the main image
                
				if (VF.Num_Fotos > 1){ //visualize next picture if there is more than 1 picture
                    VF.Next_Foto();
                    img_Posterior.Image = VF.Foto_Actual();
                    VF.Prev_Foto();
					
                    if(VF.Num_Fotos > 2) //visialize previous picture if there is more than 2 picture.
                    {
                        VF.Prev_Foto();
                        img_Previa.Image = VF.Foto_Actual();
                        VF.Next_Foto();
                    }
                }     
                
                profundidadZoom = 0;
                lbl_NombreFoto.Text = listaNombres[VF.Num_Actual].ToString(); //show the name of the picture
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_NombreFoto.Text = "No se ha cargado la imagen";
            }
			//progress bar on statusbox
            progressBar.Maximum = VF.Num_Fotos;
            progressBar.Value = 1;
            lbl_ProgressBar.Text = "1/" + (VF.Num_Fotos);

        }
/*Mouse ClickDown Event*/		
        private void img_Principal_MouseDown(object sender, MouseEventArgs e) 
        {
            if ((VF.Num_Fotos > 0) && (e.Button == MouseButtons.Left))
            {
                arrastre = true;
                offset = e.Location;
            }
        }
/*Image Movement*/		
        private void img_Principal_MouseMove(object sender, MouseEventArgs e) 
        {
            if (arrastre)
            {
                img_Principal.Location = new Point(img_Principal.Location.X + e.X - offset.X,
               img_Principal.Location.Y + e.Y - offset.Y);
            }

        }
/*Mouse clickUp Event*/		
        private void img_Principal_MouseUp(object sender, MouseEventArgs e)  
        {
            arrastre = false;
        }
		
		/*Mouse Wheel Zoom*/		
        private void img_Principal_MouseWheel(Object sender, MouseEventArgs e)  
        {
            if(e.Delta > 0)
            {
                ZoomIn();
            }
            if(e.Delta < 0)
            {
                ZoomOut();
            }
            
        }
/*Previous Image*/		
        public void seleccionarIzquierda()  
        {
            if (VF.Num_Fotos > 1)
            {
                VF.Prev_Foto();
                img_Principal.Image = VF.Foto_Actual();
                img_Principal.Location = new Point(0, 0);


                VF.Next_Foto();
                img_Posterior.Image = VF.Foto_Actual();

                VF.Prev_Foto();
                VF.Prev_Foto();
                img_Previa.Image = VF.Foto_Actual();

                VF.Next_Foto();
                profundidadZoom = 0;

                lbl_NombreFoto.Text = listaNombres[VF.Num_Actual].ToString();
                lbl_ProgressBar.Text = VF.Num_Actual + 1 + "/" + VF.Num_Fotos;
                progressBar.Value = (VF.Num_Actual + 1);

            

            }
        }
/*Next Image*/		
        public void seleccionarDerecha()    
        {
            if (VF.Num_Fotos > 1)
            {
                VF.Next_Foto();
                img_Principal.Image = VF.Foto_Actual();
                img_Principal.Location = new Point(0, 0);

                VF.Next_Foto();
                img_Posterior.Image = VF.Foto_Actual();

                VF.Prev_Foto();
                VF.Prev_Foto();
                img_Previa.Image = VF.Foto_Actual();

                VF.Next_Foto();
                profundidadZoom = 0;

                lbl_NombreFoto.Text = listaNombres[VF.Num_Actual].ToString();
                lbl_ProgressBar.Text = VF.Num_Actual + 1 + "/" + VF.Num_Fotos;
                progressBar.Value = (VF.Num_Actual + 1);
            }
        }
/*Zoom In (+)*/		
        public void ZoomIn()                                   
        {
            if ((VF.Num_Fotos > 0) && (profundidadZoom < 10))
            {
                Bitmap BM = new Bitmap(VF.Foto_Actual(), Convert.ToInt32(img_Principal.Image.Width * 1.1), Convert.ToInt32(img_Principal.Image.Height * 1.1));
                profundidadZoom += 1;
                img_Principal.Image = BM;
                int Px = (panelPicture.Width / 2) - (img_Principal.Width / 2);
                int Py = (panelPicture.Height / 2) - (img_Principal.Height / 2);
                img_Principal.Location = new Point(Px, Py);

            }
        }
/*Zoom out (-)*/		
        public void ZoomOut()                             
        {
            if ((VF.Num_Fotos > 0) && (profundidadZoom > -10))
            {
                Bitmap BM = new Bitmap(VF.Foto_Actual(), Convert.ToInt32(img_Principal.Image.Width * 0.9), Convert.ToInt32(img_Principal.Image.Height * 0.9));
                profundidadZoom -= 1;
                img_Principal.Image = BM;

                int Px = (panelPicture.Width / 2) - (img_Principal.Width / 2);
                int Py = (panelPicture.Height / 2) - (img_Principal.Height / 2);
                img_Principal.Location = new Point(Px, Py);
            }
        }

/*left rotation*/		
        public void rotarIzquierda() 
        {
            if (VF.Num_Fotos > 0)
            {
                VF.rotar_antihor();
                img_Principal.Image = VF.Foto_Actual();
                profundidadZoom = 0;
            }
        }
/*Right rotation*/		
        public void rotarDerecha() /
        {
            if (VF.Num_Fotos > 0)
            {
                VF.rotar_hor();
                img_Principal.Image = VF.Foto_Actual();
                profundidadZoom = 0;
            }
        }
/*Key press events recognition*/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)            
        {
            if (keyData == Keys.Left)
            {
                seleccionarIzquierda();
                return true;
            }
            if (keyData == Keys.Right)
            {
                seleccionarDerecha();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
/* Trim the file root to just the file name*/
        public static String formatearRaiz(String entrada) 
        {
            String texto = entrada;
            int posicion = 0;
            int cuenta = 0;
            foreach (Char x in texto)
            {
                if ('\\' == x)
                {
                    posicion = cuenta;
                }
                cuenta += 1;
            }
            posicion += 1;
            texto = texto.Substring((posicion), (texto.Length - posicion));
            return texto;
        }


        private void btn_Izquierda_Click(object sender, EventArgs e)
        {
            seleccionarIzquierda();
        }

        private void btn_Derecha_Click(object sender, EventArgs e)
        {
            seleccionarDerecha();
        }

        private void btn_SContrario_Click(object sender, EventArgs e)
        {
            if (VF.Num_Fotos > 0)
            {
                VF.rotar_antihor();
                img_Principal.Image = VF.Foto_Actual();
            }
        }

        private void btn_SHorario_Click(object sender, EventArgs e)
        {
            if (VF.Num_Fotos > 0)
            {
                VF.rotar_hor();
                img_Principal.Image = VF.Foto_Actual();
            }
        }

        private void btn_Mas_Click(object sender, EventArgs e)
        {
            ZoomIn();
            }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btn_Mas_MouseHover(object sender, EventArgs e)
        {    
            tt.SetToolTip(this.btn_Mas, "Acercarse (+)");           
        }

        private void btn_Menos_MouseHover(object sender, EventArgs e)
        {        
            tt.SetToolTip(this.btn_Menos, "Alejarse (-)");
        }

        private void img_Lupa_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.img_Lupa, "Imagen lupa");
        }

        private void btn_Derecha_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btn_Derecha, "Imagen siguiente");
        }

        private void btn_Izquierda_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btn_Izquierda, "Imagen previa");
        }

        private void btn_SHorario_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btn_SHorario, "Girar en el sentido de las agujas del reloj");
        }

        private void btn_SContrario_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btn_SContrario, "Girar la imagen en el sentido contrario a las agujas del reloj");
        }

        private void img_Principal_MouseEnter(object sender, EventArgs e)
        {
            img_Principal.Cursor = Cursors.Hand;
        }

        private void img_Principal_MouseLeave(object sender, EventArgs e)
        {
            img_Principal.Cursor = Cursors.AppStarting;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("¿Deseas salir del visor de imagenes?", "Cierre del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)){
                this.Close();
            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionarDerecha();
        }

        private void imagenPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionarIzquierda();
        }

        private void rotarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)   
        {
            rotarIzquierda();
        }

        private void rotarDerechaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            rotarDerecha();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            ZoomIn();
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void siguienteFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionarDerecha();
        }

        private void fotoPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionarIzquierda();
        }

        private void zoomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void rotarDerechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rotarDerecha();
        }

        private void rotarIzquierdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rotarIzquierda();
        }

    }
}
