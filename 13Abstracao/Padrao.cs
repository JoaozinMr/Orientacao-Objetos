abstract class Padrao
{
  // Obrigatorio
  public abstract void taxaEmprestimo(double value);

  // Opcional
  public void calcPoupanca(double value, double taxa)
  {
    Console.WriteLine("Ganhos na poupança: R$ " + (value * taxa));
  }
}