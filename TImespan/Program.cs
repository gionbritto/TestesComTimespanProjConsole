using System;
using System.Collections.Generic;
using System.Linq;

namespace TImespan
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //neste metodo eu recebo a data com o horario inicial caso precise de fazer calculos
            DateTime inicioAtendimento = DateTime.Now.ChangeTime(11, 00, 00, 0);
            //Exemplo de 1° atendimento mais o 2° atendimento
            //transformar em time span

            TimeSpan servico1 = new TimeSpan(1, 0, 0); //vem da tabela de atendimento(converter em timespan e depis em varchar quando vir da tela)
            TimeSpan servico2 = new TimeSpan(1, 0, 0);
            List<TimeSpan> tempoServicos = new List<TimeSpan> //cria uma lista com os tempos de cada serviço
            {
                servico1,
                servico2
            };

            TimeSpan tempoTotalAtendimento = tempoServicos.TotalTime();
            DateTime fimAtendimento1 = inicioAtendimento.Add(tempoTotalAtendimento);
            //fim do atendimento
            //DateTime fimAtendimento = inicioAtendimento.ChangeTime(tempoTotalAtendimento.Hours, tempoTotalAtendimento.Minutes, tempoTotalAtendimento.Seconds, tempoTotalAtendimento.Milliseconds);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ATENDIMENTO 2
            DateTime inicioAtendimento2 = DateTime.Now.ChangeTime(10, 00, 00, 0);
            TimeSpan servico3 = new TimeSpan(1, 0, 0); //vem da tabela de atendimento(converter em timespan e depis em varchar quando vir da tela)
            TimeSpan servico4 = new TimeSpan(1, 0, 0);
            List<TimeSpan> tempoServicos2 = new List<TimeSpan> //cria uma lista com os tempos de cada serviço
            {
                servico3,
                servico4
            };
            TimeSpan tempoTotalAtendimento2 = tempoServicos2.TotalTime();
            DateTime fimAtendimento2 = inicioAtendimento2.Add(tempoTotalAtendimento2);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ATENDIMENTO 3
            DateTime inicioAtendimento3 = DateTime.Now.ChangeTime(12, 00, 00, 0);
            TimeSpan servico5 = new TimeSpan(1, 0, 0); //vem da tabela de atendimento(converter em timespan e depis em varchar quando vir da tela)
            TimeSpan servico6 = new TimeSpan(1, 0, 0);
            List<TimeSpan> tempoServicos3 = new List<TimeSpan> //cria uma lista com os tempos de cada serviço
            {
                servico5,
                servico6
            };
            TimeSpan tempoTotalAtendimento3 = tempoServicos3.TotalTime();
            DateTime fimAtendimento3 = inicioAtendimento3.Add(tempoTotalAtendimento3);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ATENDIMENTO 3
            DateTime inicioAtendimento4 = DateTime.Now.ChangeTime(11, 00, 00, 0);
            TimeSpan servico7 = new TimeSpan(1, 0, 0); //vem da tabela de atendimento(converter em timespan e depis em varchar quando vir da tela)
            TimeSpan servico8 = new TimeSpan(1, 0, 0);
            List<TimeSpan> tempoServicos4 = new List<TimeSpan> //cria uma lista com os tempos de cada serviço
            {
                servico7,
                servico8
            };
            TimeSpan tempoTotalAtendimento4 = tempoServicos4.TotalTime();
            DateTime fimAtendimento4 = inicioAtendimento3.Add(tempoTotalAtendimento4);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            Console.WriteLine("Inicio Completo do Atendimento1: {0}", inicioAtendimento);
            Console.WriteLine("Tempo para o 1° serviço1: {0}", servico1);
            Console.WriteLine("Tempo para o 2° serviço1: {0}", servico2);
            Console.WriteLine("Fim Completo do Atendimento1: {0}", fimAtendimento1);
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Inicio Completo do Atendimento2: {0}", inicioAtendimento2);
            Console.WriteLine("Tempo para o 1° serviço2: {0}", servico3);
            Console.WriteLine("Tempo para o 2° serviço2: {0}", servico4);
            Console.WriteLine("Fim Completo do Atendimento2: {0}", fimAtendimento2);
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Inicio Completo do Atendimento3: {0}", inicioAtendimento3);
            Console.WriteLine("Tempo para o 1° serviço3: {0}", servico5);
            Console.WriteLine("Tempo para o 2° serviço3: {0}", servico6);
            Console.WriteLine("Fim Completo do Atendimento3: {0}", fimAtendimento3);

            //DateTime myDate1 = DateTime.Now;
            //myDate1 = myDate1.ChangeTime(10, 10, 10, 0);



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Atendimento atendimento1 = new Atendimento
            {
                IdAtendimento = Guid.NewGuid(),
                IdCliente = Guid.NewGuid(),
                IdAtendente = Guid.NewGuid(),
                IdStatusAtendimento = 1,
                IdTipoServico = Guid.NewGuid(),
                InicioAtendimento = inicioAtendimento,
                FimAtendimento = fimAtendimento1,
                TempoTotalAtendimento = tempoTotalAtendimento.ToString(),
                Ativo = true
            };

            Atendimento atendimento2 = new Atendimento
            {
                IdAtendimento = Guid.NewGuid(),
                IdCliente = Guid.NewGuid(),
                IdAtendente = Guid.NewGuid(),
                IdStatusAtendimento = 1,
                IdTipoServico = Guid.NewGuid(),
                InicioAtendimento = inicioAtendimento2,
                FimAtendimento = fimAtendimento2,
                TempoTotalAtendimento = tempoTotalAtendimento2.ToString(),
                Ativo = true
            };

            Atendimento atendimento3 = new Atendimento
            {
                IdAtendimento = Guid.NewGuid(),
                IdCliente = Guid.NewGuid(),
                IdAtendente = Guid.NewGuid(),
                IdStatusAtendimento = 1,
                IdTipoServico = Guid.NewGuid(),
                InicioAtendimento = inicioAtendimento3,
                FimAtendimento = fimAtendimento3,
                TempoTotalAtendimento = tempoTotalAtendimento3.ToString(),
                Ativo = true
            };

            Atendimento atendimento4 = new Atendimento
            {
                IdAtendimento = Guid.NewGuid(),
                IdCliente = Guid.NewGuid(),
                IdAtendente = Guid.NewGuid(),
                IdStatusAtendimento = 1,
                IdTipoServico = Guid.NewGuid(),
                InicioAtendimento = inicioAtendimento4,
                FimAtendimento = fimAtendimento4,
                TempoTotalAtendimento = tempoTotalAtendimento4.ToString(),
                Ativo = true
            };

            List<Atendimento> atendimentosDiaa = new List<Atendimento>
            {
                atendimento2,
                atendimento3,
                atendimento4
            };

            ValidarAgendamentoAtendimentoSpecification(atendimento1, atendimentosDiaa);

            //o atendimento 2 serao os atendimentos buscados no banco na mesma data
         

            Console.ReadLine();

            /*
             CAMPOS COMPLETOS DA AGENDA:
             inicioAtendimento (datetime + hora)
             fimAtendimento (datetime + hora)
             tempoTotalAtendimento (varchar9)
             */

        }

        private static void ValidarAgendamentoAtendimentoSpecification(Atendimento atendimento1, List<Atendimento> atendimentosDia)
        {

            List<string> erros = new List<string>();
            //TODO: ADICIONAR A VERIICACAO PARA O MESMO ATENDENTE, NO TESTE ESTA ALEATORIO
            if(atendimentosDia.Any(a => a.InicioAtendimento.Date == atendimento1.InicioAtendimento.Date)) //existe no banco outro atendimento na mesma data
            {
                foreach (var item in atendimentosDia)
                {
                    //verificacao de horario inicio
                    if (item.InicioAtendimento >= atendimento1.InicioAtendimento 
                        && item.FimAtendimento <= atendimento1.InicioAtendimento 
                        && item.Ativo 
                        && item.IdStatusAtendimento == 1) //verificar se ativo e se agendado (diferente de cancelado ou finalizado)
                    {
                        var mensagem = String.Format("Ja existe um agendamento com inicio em {0} e fim {1} para o atendente: {2}, cliente: {3}", item.InicioAtendimento, item.FimAtendimento, item.IdAtendente, item.IdCliente);
                        erros.Add(mensagem);
                    }

                    if (item.InicioAtendimento <= atendimento1.InicioAtendimento
                      && item.FimAtendimento >= atendimento1.InicioAtendimento
                      && item.Ativo
                      && item.IdStatusAtendimento == 1) //verificar se ativo e se agendado (diferente de cancelado ou finalizado)
                    {
                        var mensagem = String.Format("Ja existe um agendamento com inicio em {0} e fim {1} para o atendente: {2}, cliente: {3}", item.InicioAtendimento, item.FimAtendimento, item.IdAtendente, item.IdCliente);
                        erros.Add(mensagem);
                    }

                    //verificacao de horario finalizacao (a finalizacao do que esta tentando ser marcado esta no momento do atendimento ja marcado)
                    if (item.InicioAtendimento <= atendimento1.FimAtendimento
                        && item.FimAtendimento >= atendimento1.FimAtendimento
                        && item.Ativo
                        && item.IdStatusAtendimento == 1) //verificar se ativo e se agendado (diferente de cancelado ou finalizado)
                    {
                        var mensagem = String.Format("Ja existe um agendamento com inicio em {0} e fim {1} para o atendente: {2}, cliente: {3}", item.InicioAtendimento, item.FimAtendimento, item.IdAtendente, item.IdCliente);
                        erros.Add(mensagem);
                    }

                    if (item.InicioAtendimento == atendimento1.InicioAtendimento
                        && item.FimAtendimento == atendimento1.FimAtendimento
                        && item.Ativo
                        && item.IdStatusAtendimento == 1) //verificar se ativo e se agendado (diferente de cancelado ou finalizado)
                    {
                        var mensagem = String.Format("Ja existe um agendamento com inicio em {0} e fim {1} para o atendente: {2}, cliente: {3}", item.InicioAtendimento, item.FimAtendimento, item.IdAtendente, item.IdCliente);
                        erros.Add(mensagem);
                    }

                }
                erros.ForEach(x =>
                    Console.WriteLine(x)
                );
                
            }
        }
    }

    static class TimeManager
    {
        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }

        public static TimeSpan TotalTime(this IEnumerable<TimeSpan> TheCollection)
        {
            int i = 0;
            int TotalSeconds = 0;

            var ArrayDuration = TheCollection.ToArray();

            for (i = 0; i < ArrayDuration.Length; i++)
            {
                TotalSeconds = (int)(ArrayDuration[i].TotalSeconds) + TotalSeconds;
            }

            return TimeSpan.FromSeconds(TotalSeconds);
        }
    }

    public class Atendimento
    {
        public Guid IdAtendimento { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdAtendente { get; set; }
        public Guid IdTipoServico { get; set; }
        public int IdStatusAtendimento { get; set; } 
        public DateTime InicioAtendimento { get; set; }
        public DateTime FimAtendimento { get; set; }
        public string TempoTotalAtendimento { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool  Ativo { get; set; }

    }
}
