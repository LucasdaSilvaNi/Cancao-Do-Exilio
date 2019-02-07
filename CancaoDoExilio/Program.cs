using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terra minhaTerra = new Terra();
            Console.WriteLine(GerarPrimeiraEstrofe(minhaTerra));
            Console.WriteLine(GerarSegundaEstrofe(minhaTerra));
            Console.WriteLine(GerarTerceiraEstrofe(minhaTerra));
            Console.WriteLine(GerarQuartaEstrofe(minhaTerra));
            Console.WriteLine(GerarQuintaEstrofe(minhaTerra));
            Console.ReadKey();
        }

        public static string GerarPrimeiraEstrofe(Terra minhaTerra, bool web = false)
        {
            StringBuilder estrofe = new StringBuilder("\"Minha Terra ");

            if(minhaTerra.palmeiras.Length > 0)
            {
                estrofe.Append("tem ");
            }
            else
            {
                estrofe.Append("não tem ");
            }

            estrofe.Append("palmeiras,\nOnde ");

            if(minhaTerra.sabiaCanta)
            {
                estrofe.Append("canta ");
            }
            else
            {
                estrofe.Append("não canta ");
            }

            estrofe.Append("o Sabiá;\n");

            if(minhaTerra.aves.Count > 0 && minhaTerra.aves.FirstOrDefault().ObterGojeio() > 0)
            {
                estrofe.Append("As aves, que aqui gorjeiam,\nNão gorjeiam como lá.");
            }
            else
            {
                estrofe.Append("Aqui não tem aves que gorjeiam.\n");
            }

            if (web) 
                return paraWeb(estrofe);
            else
                return estrofe.ToString();
        }

        public static string GerarSegundaEstrofe(Terra minhaTerra, bool web = false)
        {
            StringBuilder estrofe = new StringBuilder("Nosso céu ");

            string temMais = minhaTerra.ObterQuantidadeCoisas() == 32 ? "têm mais " : "não têm mais ";

            estrofe.Append(temMais.Replace("ê","e"));
            estrofe.Append("estrelas,\nNossas várzeas ");
            estrofe.Append(temMais);
            estrofe.Append("flores,\nNossos bosques ");
            estrofe.Append(temMais);
            estrofe.Append("vida,\nNossa vida mais amores.\n");

            if (web)
                return paraWeb(estrofe);
            else
                return estrofe.ToString();
        }

        public static string GerarTerceiraEstrofe(Terra minhaTerra, bool web = false)
        {
            string texto = "";

            StringBuilder estrofe = new StringBuilder();


            if (string.IsNullOrEmpty(texto))
            {
                estrofe.Append("Em cismar, sozinho, à noite,\nMais prazer encontro eu lá;\nMinha terra tem palmeiras,\nOnde canta o Sabiá.\n");
            }
            else
            {
                estrofe.Append(@"Em cismar, sozinho, à noite,prazer encontro eu lá;\n
                                Minha terra palmeiras,\nOnde canta a Alcione.\n\n");
            }
            if (web)
                return paraWeb(estrofe);
            else
                return estrofe.ToString();
        }

        public static string GerarQuartaEstrofe(Terra minhaTerra, bool web = false)
        {
            StringBuilder estrofe = new StringBuilder("Minha terra ");

            if(minhaTerra.ObterPrimores())
            {
                estrofe.Append("tem ");
            }
            else
            {
                estrofe.Append("não tem ");
            }

            estrofe.Append("primores\n");

            List<string> frases = new List<string>()
            {
                "Que tais não encontro eu cá;",
                "Em cismar — sozinho, à noite,",
                "Mais prazer encontro eu lá;",
                "Minha terra tem palmeiras,",
                "Onde canta o Sabiá."
            };

                for (int i = 0; i < frases.Count; i++)
                {
                    estrofe.Append(frases[i]);
                    estrofe.Append("\n");
                }

            if (web)
                return paraWeb(estrofe);
            else
                return estrofe.ToString();

        }

        public static string GerarQuintaEstrofe(Terra minhaTerra, bool web = false)
        {
            StringBuilder estrofe = new StringBuilder("Não permita Deus que eu morra,\n");

            Ave ave = new Ave();
            PreencherAve(ref ave);

            if(ave.TipoAsas == "Grandes")
            {
                estrofe.Append("Sem que eu volte para lá;\n");
            }
            else
            {
                estrofe.Append("Se não tem asas grandes não faz sentido;\n");
            }

            if (minhaTerra.ObterPrimores())
            {
                estrofe.Append("Sem que desfrute os primores\n");
            }
            else
            {
                estrofe.Append("Chega dessas condiciones;\n");
            }

            Palmeira palmeira = new Palmeira();
            palmeira.folha = "Folha de Bananeira";
            PreencherPalmeira(ref palmeira);

            if (palmeira.folha == "Folha de Palmeira")
            {
                estrofe.Append("Que não encontro por cá;\n");
            }
            else
            {
                estrofe.Append("Eu encontrei por aqui;\n");
            }

            if (Convert.ToBoolean(minhaTerra.QuantidadePalmeirasAvistadas))
            {
                estrofe.Append("Sem qu'inda aviste as palmeiras,\n");
            }
            else
            {
                estrofe.Append("Não avistei palmeiras;\n");
            }

            estrofe.Append("Onde canta o Sabiá.\"");

            minhaTerra.Terminou = true;

            if (web)
                return paraWeb(estrofe);
            else
                return estrofe.ToString();
        }

        static void PreencherAve(ref Ave ave)
        {
            ave = new Ave();
            ave.TipoAsas = "Grandes";
        }

        static void PreencherPalmeira(ref Palmeira palmeira)
        {
            palmeira = new Palmeira();
            palmeira.folha = "Folha de Palmeira";
        }

        static string paraWeb(StringBuilder estrofe) {
            estrofe.Replace("\n", "<br/>");
            estrofe.Append("<br/><br/>");
            return estrofe.ToString();
        }
    }
}
