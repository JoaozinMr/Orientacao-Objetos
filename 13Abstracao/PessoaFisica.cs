class PessoaFisica : Padrao
{
  public override void taxaEmprestimo(double value)
  {
    Console.WriteLine("Taxa de empréstimo para Pessoa Física: R$ " + (value * 0.1));
  }
}