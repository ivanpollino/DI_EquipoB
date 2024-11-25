using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.ComponentesPersonalizados
{
    public partial class TextArea : UserControl
    {
        private const int ResizeHandleSize = 10; // Tamaño del área de arrastre en las esquinas
        private bool isResizing = false;
        private Point lastMousePosition;

        public TextArea()
        {
            InitializeComponent();
            InitializeTextBox();
        }

        private TextBox txtArea;

        private void InitializeTextBox()
        {
            // Crear el TextBox
            txtArea = new TextBox
            {
                Multiline = true,           // Permite múltiples líneas
                Dock = DockStyle.Fill,      // El TextBox ocupa todo el espacio disponible
                ScrollBars = ScrollBars.Vertical, // Agrega una barra de desplazamiento vertical
                AcceptsReturn = true,       // Permite saltos de línea
                Font = new Font("Arial", 10), // Puedes personalizar la fuente
                BorderStyle = BorderStyle.FixedSingle // Establece un borde alrededor del TextBox
            };

            // Agregar el TextBox al control de usuario
            this.Controls.Add(txtArea);

            // Activar el redimensionamiento del control
            this.MouseDown += TextArea_MouseDown;
            this.MouseMove += TextArea_MouseMove;
            this.MouseUp += TextArea_MouseUp;
        }

        // Propiedad para obtener o establecer el texto del TextBox
        public string Text
        {
            get { return txtArea.Text; }
            set { txtArea.Text = value; }
        }

        // Propiedad para obtener o establecer el número de filas (líneas de texto)
        public int Rows
        {
            get
            {
                // Calcula el número de líneas basadas en la altura del control y la altura de la fuente
                return (int)(this.Height / txtArea.Font.GetHeight());
            }
            set
            {
                // Establece la altura del control en función del número de filas deseadas
                this.Height = value * (int)txtArea.Font.GetHeight();
            }
        }

        // Hacer que el control sea redimensionable
        private void TextArea_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar si el mouse está en el área de la esquina para redimensionar
            if (e.X >= this.Width - ResizeHandleSize && e.Y >= this.Height - ResizeHandleSize)
            {
                isResizing = true;
                lastMousePosition = e.Location;
                this.Cursor = Cursors.SizeNWSE; // Cambia el cursor para indicar redimensionamiento
            }
        }

        private void TextArea_MouseMove(object sender, MouseEventArgs e)
        {
            // Cambiar el cursor si estamos sobre la esquina de redimensionado
            if (e.X >= this.Width - ResizeHandleSize && e.Y >= this.Height - ResizeHandleSize)
            {
                this.Cursor = Cursors.SizeNWSE; // Cursor de redimensionamiento diagonal
            }
            else
            {
                this.Cursor = Cursors.Default;
            }

            // Redimensionar el control cuando se esté arrastrando
            if (isResizing)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                this.Width += deltaX;
                this.Height += deltaY;

                lastMousePosition = e.Location;
            }
        }

        private void TextArea_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
            this.Cursor = Cursors.Default; // Restaura el cursor cuando ya no se está redimensionando
        }
    }
}
