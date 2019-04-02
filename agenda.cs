using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace C_Sharp_Intermediario
{
    public partial class frm_Agenda : Form
    {
        public frm_Agenda()
        {
            InitializeComponent();
        }
        private void frm_Agenda_Load(object sender, EventArgs e)
        {
            CriarContato();
            lbl_Titulo.Text = CarregarTitulo();
            CarregarContatos();
        }
        private string CarregarTitulo()
        {
            //XmlDocument: Classe para manipulação de arquivos XML.
            XmlDocument docXML = new XmlDocument();
            //Carrega o arquivo com os nós e seus respectivos dados.
            docXML.Load(@"C:\Users\Vostro 5480\OneDrive\DEV\RepositGit\XML_Aula\Agenda.xml");

            //SelectSingleNode: retorna apenas um nó ou, no caso de mais de um, retorna o primeiro.
            XmlNode nohTitulo = docXML.SelectSingleNode("//titulo");

            return nohTitulo.InnerText;
        }
        //Carrega lista de contatos.
        private void CarregarContatos()
        {
            XmlDocument docXML = new XmlDocument();
            docXML.Load(@"C:\Users\Vostro 5480\OneDrive\DEV\RepositGit\XML_Aula\Agenda.xml");
            
            //XMLNodeList: Carrega lista de nós. | SelectNodes: retorna todos os nós existentes no xPath.
            XmlNodeList contatos = docXML.SelectNodes("//contato");

            //XMLNode: Carrega apenas um nó por iteração.
            foreach (XmlNode contato in contatos)
            {
                //Attributes: Captura o atributo do nó.
                string id = contato.Attributes["id"].Value;
                string nome = contato.Attributes["nome"].Value;
                string telefone = contato.Attributes["telefone"].Value;
                //formatação dos itens.
                string representacaoContato = nome + ", " + telefone + ", " + id;
                //Insere os itens na lista.
                lbx_Contato.Items.Add(representacaoContato);
            }
        }
        private void CriarContato()
        {
            XmlDocument docXML = new XmlDocument();
            docXML.Load(@"C:\Users\Vostro 5480\OneDrive\DEV\RepositGit\XML_Aula\Agenda.xml");
            
            //Criar os atributos da tag contato.
            XmlAttribute atribId = docXML.CreateAttribute("id");
            atribId.Value = "5";
            XmlAttribute atribNome = docXML.CreateAttribute("nome");
            atribNome.Value = "teste novo elemento";
            XmlAttribute atribTelefone = docXML.CreateAttribute("telefone");
            atribTelefone.Value = "67 99995555";

            //Cria uma nova (tag) contato e adiciona os respetivos atributos.
            XmlNode novoContato = docXML.CreateElement("contato");
            novoContato.Attributes.Append(atribId);
            novoContato.Attributes.Append(atribNome);
            novoContato.Attributes.Append(atribTelefone);

            //Adiciona (Vincula) a nova tag ao nó contatos.
            XmlNode contatos = docXML.SelectSingleNode("//contatos");
            contatos.AppendChild(novoContato);

            //Salva um novo arquivo sobrescrevendo o anterior.
            docXML.Save(@"C:\Users\Vostro 5480\OneDrive\DEV\RepositGit\XML_Aula\Agenda.xml");
        }
    }
}
