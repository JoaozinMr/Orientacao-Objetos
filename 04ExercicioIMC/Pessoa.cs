class Pessoa
{

  public double peso, altura;


  public double IMC()
  {
    return peso / (altura * altura);
  }


  public string condicao(double imc)
  {
    string retorno;

    if (imc < 18.5)
    {
      retorno = "Abaixo do peso";
    }
    else if (imc < 25)
    {
      retorno = "Peso normal";
    }
    else if (imc < 30)
    {
      retorno = "Acima do peso";
    }
    else if (imc < 35)
    {
      retorno = "Obesidade I";
    }
    else if (imc < 40)
    {
      retorno = "Obesidade II";
    }
    else
    {
      retorno = "Obesidade III";
    }
    return retorno;
  }

  public void mensagem()
  {

    double obterImc = IMC();
    
    string obterRetorno = condicao(obterImc);

    Console.WriteLine("Seu IMC é de: " + obterImc + "\n Sua situação é: " + obterRetorno);
  }
}
