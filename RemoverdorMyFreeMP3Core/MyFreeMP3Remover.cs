using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RemoverdorMyFreeMP3Core
{
    public partial class MyFreeMP3Remover : Form
    {
        public MyFreeMP3Remover()
        {
            InitializeComponent();
            lblCaminho.Text = "Selecione uma pastas para ver seu caminho aqui...";
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
                lblCaminho.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtRemover.Text) && String.IsNullOrWhiteSpace(txtDuplicado.Text))
                MessageBox.Show("Digite um texto válido!");
            else
                ExecutarLimpeza();
        }

        private void ExecutarLimpeza()
        {
            IEnumerable<string> EnumArquivos = Directory.GetFiles(lblCaminho.Text);
            if (!String.IsNullOrWhiteSpace(txtRemover.Text))
                RemoverString(EnumArquivos);
            if (!String.IsNullOrWhiteSpace(txtDuplicado.Text))
                RemoverDuplicado(EnumArquivos);
            MessageBox.Show("Limpeza concluída!");
        }

        private void RemoverString(IEnumerable<string> EnumArquivos) =>
            EnumArquivos.Where(arq => arq.Contains(txtRemover.Text)).ToList().ForEach(arq => File.Move(arq, arq.Replace(txtRemover.Text, "")));
        
        private void RemoverDuplicado(IEnumerable<string> EnumArquivos) =>
            EnumArquivos.Where(arq => EhDuplicado(txtDuplicado.Text, arq)).ToList().ForEach(arq => File.Move(arq, arq.Remove(arq.LastIndexOf(txtDuplicado.Text), txtDuplicado.Text.Length)));
        
        private static bool EhDuplicado(string txtToRemove, string arq) =>
           (arq.IndexOf(txtToRemove) != arq.LastIndexOf(txtToRemove)) && arq.IndexOf(txtToRemove) > -1 && arq.LastIndexOf(txtToRemove) > -1;
    }
}
