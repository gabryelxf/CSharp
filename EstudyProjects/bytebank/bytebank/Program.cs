
using bytebank.Contas;
using bytebank.Excecoes;
using bytebank.Titular;
using bytebank.Utilitarios;
using System;


class program
{
    static void Main(string[] args)
    {
        CarregarContas();
        //Metodo();
        Console.ReadLine();
    }

    public static void CarregarContas()
    {
        LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

        try
        {
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            leitor.Fechar();
        }

        

    }



    public static void TesteExcecao()
    {
        try
        {
            Cliente teste = new Cliente();
            teste.NomeCliente = "teste";
            ContaCorrente conta = new ContaCorrente(teste, 8, 2);
            ContaCorrente conta2 = new ContaCorrente(teste, 3, 1);
            Console.WriteLine(conta.Saldo);
            conta.depositar(50);



            Console.WriteLine(conta.Saldo);
            //conta.sacar(500);

            Console.WriteLine("Comecando transferencia");
            Console.WriteLine(ContaCorrente.ContadorTransferenciasNaoPermitidas);
            conta.transferir(500, conta2);

            Console.WriteLine("Terminando transferencia");

            Console.WriteLine("Saldo conta 1: " + conta.Saldo);
            Console.WriteLine("Saldo conta 2: " + conta2.Saldo);


            Console.WriteLine(conta.Saldo);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Deu erro em: " + ex.ParamName);
            Console.WriteLine("Deu erro ai: " + ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
            // Console.WriteLine(ex.StackTrace);
        }
        catch (OperacaoFincanceiraException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException.Message);
            Console.WriteLine(ContaCorrente.ContadorTransferenciasNaoPermitidas);

        }
        // ContaCorrente contaErro = new ContaCorrente(teste, 0, 0);


        Console.WriteLine("Pressione Enter para sair");
        Console.ReadLine();

    }
    public static void Teste()
    {
       /* Cliente joao = new Cliente();
        joao.NomeCliente = "Joao";
        joao.IdadeCliente = 25;
        Console.WriteLine(joao.IdadeCliente);
        ContaCorrente contaJao = new ContaCorrente(joao, "1111-X", 17);

        contaJao.setSaldo(1000.00);

        Console.WriteLine(contaJao.getTitular());
        Console.WriteLine(contaJao.getAgencia());

        contaJao.depositar(100.00);
        Console.WriteLine(contaJao.getSaldo());

        contaJao.sacar(50.00);
        Console.WriteLine(contaJao.getSaldo());

        Cliente maria = new Cliente();
        joao.NomeCliente = "Maria";
        ContaCorrente contaMaria = new ContaCorrente(maria, "8888-X", 15);

        Console.WriteLine("Saldo Maria");
        Console.WriteLine(contaMaria.getSaldo());

        contaJao.transferir(500.00, contaMaria);

        Console.WriteLine("pós Saque:");
        Console.WriteLine("Joao: " + contaJao.getSaldo());
        Console.WriteLine("Maria: " + contaMaria.getSaldo());


        if (contaJao.sacar(1000.00))
        {
            Console.WriteLine("Joao: " + contaJao.getSaldo());
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque");
        }

        if (contaJao.sacar(500.00))
        {
            Console.WriteLine("Sacou irmao");
            Console.WriteLine("Joao: " + contaJao.getSaldo());
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque");
        }


        ContaCorrente contaTeste = new ContaCorrente();

        Console.WriteLine("a" + contaTeste.getTitular() + "a");
        Console.WriteLine("a" + contaTeste.getConta() + "a");
        Console.WriteLine("a" + contaTeste.getSaldo() + "a");
        Console.WriteLine("a" + contaTeste.getAgencia() + "a");
        Console.WriteLine("Total contas criadas: " + ContaCorrente.TotalContasCriadas);

        Console.WriteLine("Aperte Enter para fechar.");
        Console.ReadLine();*/

    }

}


