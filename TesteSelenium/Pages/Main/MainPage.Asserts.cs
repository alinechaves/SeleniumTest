using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteSelenium.Pages
{
    public partial class MainPage
    {
        public void ValidaBotaoLoginNaTela()
        {
            Assert.IsTrue(FazerLoginBtn.Displayed);
        }

        public void ValidaGmailLinkNaTela()
        {
            Assert.IsTrue(GmailLink.Displayed);
        }

        public void ValidaContaLinkNaTela()
        {
            Assert.IsTrue(ContaLink.Displayed);
        }

        public void ValidaNomeContaNaTela(string nome)
        {
            Assert.IsTrue(NomaConta.Text.Equals(nome));
        }
    }
}
