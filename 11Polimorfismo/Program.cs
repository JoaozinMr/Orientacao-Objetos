Imposto objEst = new Estagiario();
objEst.valeAlimentacao(1000);
objEst.valeTransporte(1000);
Console.WriteLine("----------------------");

Imposto objGerente = new Gerente();
objGerente.valeAlimentacao(5000);
objGerente.valeTransporte(5000);
Console.WriteLine("----------------------");


Imposto objAtendente = new Atendente();
objAtendente.valeAlimentacao(2000);
objAtendente.valeTransporte(2000);
Console.WriteLine("----------------------");