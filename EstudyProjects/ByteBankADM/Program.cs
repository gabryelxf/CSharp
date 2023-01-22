using ByteBankADM.Funcionarios;
using ByteBankADM.SistemaInterno;

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("854755", 5000, "123", "ingrid");
    ingrid.Senha = "123";
    ingrid.Nome = "ingrid";

    GerenteDeContas joao = new GerenteDeContas("458777", 4000, "456", "jao");
    joao.Nome = "joao";
    

    //Auxiliar aux = new Auxiliar("45450", 1000);
    //sistema.Logar(aux, "444");
    sistema.Logar(ingrid, "123", "ingrid");
    sistema.Logar(joao, "456", "jao");
}

Console.WriteLine("Aperte Enter para finalizar");
Console.ReadLine();