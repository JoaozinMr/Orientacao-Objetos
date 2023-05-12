class PessoaJuridica : Padrao
{
  public override void taxaEmprestimo(double value)
  {
    Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica: R$ " + (value * 0.2));
  }
}