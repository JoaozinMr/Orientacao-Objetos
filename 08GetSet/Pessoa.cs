class Pessoa
{
  private string nome = "";

  public string Nome // Tbm dá pra fazer assim  => { get; set; }
  {
    get { return this.nome; }
    set { this.nome = value; }
  }
}