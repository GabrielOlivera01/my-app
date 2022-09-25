using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STRINGS
            //===========STRINGS===============
            //Exemplos_Guid();
            //Exemplos_Interpolacao();
            //Exemplos_ComparacaoTextos();
            //Exemplos_Indices();
            //Exemplos_Converssoes();
            //Exemplos_Adicionais();
            //Exemplos_ManipulandoStrings();
            //Exemplos_StringBuilder();
            #endregion

            #region DATAS
            //===========DATAS================
            // Exemplos_Criacao();
            // Exemplos_Formatacoes();
            // Exemplos_Manipulacao();
            // Exemplos_CultureInfo();
            // Exemplos_TimeZones();
            // Exemplos_TimeSpan();
            // Exemplos_Adicionais();
            #endregion

            #region MOEDAS
            // ==========MOEDAS===============
            // Exemplos_TiposParaMoedas();
            // Exemplos_FormatandoMoedas();
            // Exemplos_Math();

            #endregion

            #region

            #endregion
        }
    }

    public static class StringClass
    {
        static void Exemplos_Guid()
        {
            Guid id = Guid.NewGuid(); //Gera um novo Guid automatico.

            id = new Guid("e253082d-af01-4161-8c8a-d5b698c86d53"); //Gera um Guid com base no valor passado (o valor deve estar no  formato válido de um Guid) 

            id = new Guid(); //Exibe o formato de um Guid

            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));
        }

        static void Exemplos_Interpolacao()
        {
            double price = 10.2;
            //string texto = "O preço do produto é " + price;
            //string texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            string texto = $"O preço do produto é {price} somete hoje!";

            Console.WriteLine(texto);
        }

        static void Exemplos_ComparacaoTextos()
        {
            //string texto = "Testando";
            // Console.WriteLine(texto.CompareTo("Testando"));
            // Console.WriteLine(texto.CompareTo("testando"));
            //Sem Case Sensitive
            //Console.WriteLine(texto.CompareTo("testando"));

            //string texto = "Este texto é um teste";
            //Console.WriteLine(texto.Contains("teste"));
            //Console.WriteLine(texto.Contains("Teste"));
            //Sem Case Sensitive
            //Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            //string texto = "Este texto é um teste";
            //Console.WriteLine(texto.StartsWith("este"));
            //Console.WriteLine(texto.StartsWith(" Este"));
            //Console.WriteLine(texto.StartsWith("Este"));
            //Sem Case Sensitive
            //Console.WriteLine(texto.StartsWith("este",StringComparison.OrdinalIgnoreCase));

            //string texto = "Este texto é um teste";
            //Console.WriteLine(texto.EndsWith("teste"));
            //Console.WriteLine(texto.EndsWith("Teste"));
            //Sem Case Sensitive
            //Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));


            string texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            //Sem Case Sensitive
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }

        static void Exemplos_Indices()
        {
            string texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("um"));
            Console.WriteLine(texto.IndexOf("Um"));

            Console.WriteLine(texto.LastIndexOf("t"));
            Console.WriteLine(texto.LastIndexOf("e"));
        }

        static void Exemplos_Converssoes()
        {
            string texto = "Este texto é um teste";

            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
        }

        static void Exemplos_Adicionais()
        {
            string texto = "Um texto de exemplo";

            Console.WriteLine(texto);
            Console.WriteLine(texto.Length);
            Console.WriteLine(texto.Insert(3, "AQUI FOI INSERIDO "));
            Console.WriteLine(texto.Remove(3, 6));
        }

        static void Exemplos_ManipulandoStrings()
        {
            string texto = "Este texto é um teste";

            //Console.WriteLine(texto.Replace("Este", "Isso"));
            //Console.WriteLine(texto.Replace("e", "X"));

            string[] lista = texto.Split(" ");
            int tamanhoLista = lista.Length;

            for (var item = 0; item < tamanhoLista; item++)
            {
                Console.WriteLine(lista[item]);
            }

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(" ");
            Console.WriteLine(resultado);

            var textoComEspacos = "  Este é um exemplo de testo com espaço  ";
            var textoComEspacos2 = "  Este é um exemplo de testo com espaço  ";
            var textoComEspacos3 = "  Este é um exemplo de testo com espaço  ";

            //OBS: ESPAÇOS ENTRE, O TRIM NÃO PEGA, SÓ OS NO COMEÇO E FINAL.
            Console.WriteLine(textoComEspacos.Trim());
            Console.WriteLine(textoComEspacos2.TrimStart());
            Console.WriteLine(textoComEspacos3.TrimEnd());

        }

        static void Exemplos_StringBuilder()
        {
            //Multiplas linhas em uma string (quebrar a string)
            string texto = @"Agora posso escrever o
            texto quebando ele que o C# vai aceitar.";

            Console.WriteLine(texto);

            StringBuilder texto2 = new StringBuilder();
            texto2.Append("Este ");
            texto2.Append("é um ");
            texto2.Append("teste");
            texto2.ToString();

            Console.WriteLine(texto2);
        }
    }

    public static class DataClass
    {
        static void Exemplos_Criacao()
        {
            //var data = new DateTime(); //Cria uma strutura datetime
            //var data = DateTime.Now; //Pega a data e hora atual

            //var data = new DateTime(2022, 09, 22, 08, 10, 59); //Cria uma data e um horário especifico
            //var ano = data.Year; //Pega o ano da variavel data
            //var mes = data.Month; //Pega o mes da variavel data
            //var dia = data.Day;//Pega o dia da variavel data

            //var horas = data.Hour; //Pega a hora da variavel data
            //var minutos = data.Minute; //Pega os minuto da variavel data
            //var segundos = data.Second; //Pega os segundos da variavel data

            //var diaDaSemana = data.DayOfWeek; //Retorna o dia da semana que é a data (Tras o nome)
            //var diaDaSemanaInt = (int)data.DayOfWeek; //Retorna o dia da semana que é a data (Tras um int referente ao dia da semana)
        }

        static void Exemplos_Formatacoes()
        {
            //var data = DateTime.Now;
            //Ano: y | Mês: M | Dia: d | Hora: h | Minuto: m | Segundo: s | Fração de segundo: f | Time Zone: z | Data Compactada:(t = Data mais curta, d = menor data, T = temp longo, D = data por extenso, f = data e hora, g = data e hora compactada, r = data em um padrao, R = outro padrao, s = ouro padrao, u = padrão universal)
            //var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data, data);
        }

        static void Exemplos_Manipulacao()
        {
            // var data = DateTime.Now;
            // var dia = data.Day + 1; //Evitar usar

            // int adicao = 1;
            // int subtracao = -1;

            // var novoDia = data.AddDays(adicao); //Incrementa 1 ao dia
            // var novoMes = data.AddMonths(adicao);//Incrementa 1 ao mes
            // var novoAno = data.AddYears(adicao);//Incrementa 1 ao ano

            // var novaHora = data.AddHours(subtracao);//Diminui 1 da hora
            // var novoMinuto = data.AddMinutes(subtracao);//Diminui 1 do minuto
            // var novoSegundo = data.AddSeconds(subtracao);//Diminui 1 do segundo

            //Console.WriteLine(novoMes);
        }

        static void Exemplos_TimeZones()
        {
            var pt = new CultureInfo("pt-PT"); //Português Portugal
            var br = new CultureInfo("pt-BR"); //Português Brasil
            var en = new CultureInfo("en-US"); //Inglês Americano
            var enBrit = new CultureInfo("en-UK"); //Inglês Britânico
            var de = new CultureInfo("de-DE"); //Dinamarca

            var culturaAtual = CultureInfo.CurrentCulture;//Pega a cultura da máquina que está rodando

            Console.WriteLine(DateTime.Now.ToString("D", culturaAtual));
            Console.WriteLine(DateTime.Now.ToString("D", de));

            var utcDate = DateTime.UtcNow; //Universal time, vai pegar a data base sem nenhum time zone (Para aplicações globalizadas)
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();//Pega todos os timezones cadastrados no sistema

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("----------------------------");
            }
        }

        static void Exemplos_TimeSpan()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 30, 50, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }

        static void Exemplos_Adicionais()
        {
            var qtsDiasTemOMes = DateTime.DaysInMonth(2022, 2); //Retorna quantos dias tem no mês especificado.
            Console.WriteLine(qtsDiasTemOMes);

            var ultimoMes = 12;

            for (int mes = 1; mes <= ultimoMes; mes++)
            {
                Console.Write(DateTime.DaysInMonth(DateTime.Now.Year, mes));

                if (mes < ultimoMes)
                {
                    Console.Write("-");
                }
            }

            //----------------------------------------------------------------------
            var eFinalDeSemana = IsWeekend(DateTime.Today.DayOfWeek);

            if (eFinalDeSemana)
            {
                Console.WriteLine("Hoje é Final de Semana");
            }
            else
            {
                Console.WriteLine("Hoje Não é Final de Semana");
            }

            //Função que verifica se o dia é final de semana ou não
            static bool IsWeekend(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
            //---------------------------------------------------------------------------

            var horarioDeVerao = DateTime.Now.IsDaylightSavingTime(); //Verifica se é horário de verão
            if (horarioDeVerao)
            {
                Console.WriteLine("É horário de verão");
            }
            else
            {
                Console.WriteLine("Não é horário de verão");
            }
        }
    }

    public static class Moedas
    {
        static void Exemplos_TiposParaMoedas()
        {
            //Precisão grande da moeda: decimal (mais recomendado)
            decimal valor = 10.25m;
            Console.WriteLine(valor);
        }

        static void Exemplos_FormatandoMoedas()
        {
            decimal valor = 10.25m;
            Console.WriteLine(valor.ToString(
                "C", //Formatadores (G: Numérico, C: Moeda, E04: Quando o múmero é muito grande, F: Trás uma casa decimal a mais(bom para fazer arredondamento), N: Formata para número sem o tipo da moeda, P: Formata com a porcentagem)
                CultureInfo.CreateSpecificCulture("pt-BR")//Converte o valor para a cultura especifica.
            ));
        }

        static void Exemplos_Math()
        {
            decimal valor = 10536.25m;
            Console.WriteLine(
                Math.Round(valor) //Arredonda o valor na média (tira oq vem depois do ".")
            );

            Console.WriteLine(
                Math.Ceiling(valor) //Arredonda o valor pra cima
            );

            Console.WriteLine(
                Math.Floor(valor) //Arredonda o valor pra baixo
            );
        }

    }
}