//Esta clase fue realizado por:
//Omar Ernesto Rivera Hernández - 20240600 - Coordinador PTC

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios.Componentes_Nuevos
{
    public abstract class IPES_CDD
    {
        //<----------------------------------------------------------------------------------->
        // Muestra un cuadro de diálogo modal con el texto especificado y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text))
                result = msgForm.ShowDialog();
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto y el título especificados, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título y los botones especificados, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título, los botones y el icono especificados, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título, los botones, el icono y el botón predeterminado especificados, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }
        //<----------------------------------------------------------------------------------->

        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        // Muestra un cuadro de diálogo modal con el texto especificado y el propietario especificado, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto y el título especificados, y el propietario especificado, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título y los botones especificados, y el propietario especificado, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título, los botones y el icono especificados, y el propietario especificado, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        //<----------------------------------------------------------------------------------->

        // Muestra un cuadro de diálogo modal con el texto, el título, los botones, el icono y el botón predeterminado especificados, y el propietario especificado, y devuelve el resultado del cuadro de diálogo.
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMensajedeDialogo(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        //<----------------------------------------------------------------------------------->

    }
}