using System;
using System.Collections.Generic;

class Mostruario{

  private Vendedor Representante;
  
  public List<Veiculo> carros;

  public Mostruario(Vendedor v){

    Representante = v;
    carros = new List<Veiculo>(); //INSTANCIAR LISTA VAZIA

  }

  public void setRepresentante(Vendedor v){

      Representante = v;

  }

  //CONSTRUTOR VAZIO
  public Mostruario(){

  }

  public void calculaValor(){

   int sair = 0; //VARIÁVEL PARA CONTROLAR A EXECUÇÃO DO WHILE

  //ATRIBUINDO OS DADOS DE UM VENDEDOR
   Vendedor Webhe = new Vendedor("WEBHE",2000.34,1.34); 
   Mostruario secaoA = new Mostruario(Webhe);
   secaoA.setRepresentante(Webhe); 
   
   
   while(sair == 0){   
    Console.WriteLine("DIGITE UMA MARCA DE CARRO"); 
    string marca = Console.ReadLine();
    Console.WriteLine("DIGITE O ANO DO CARRO");
    int ano = int.Parse(Console.ReadLine());
    Console.WriteLine("DIGITE O KM DO CARRO");
    int km = int.Parse(Console.ReadLine());
    Console.WriteLine("DIGITE O VALOR DO CARRO");
    double valorVeiculo = double.Parse(Console.ReadLine());


    Veiculo uno = new Veiculo(marca,ano,km,valorVeiculo);  //PASSANDO OS ATRIBUTOS PARA O TIPO VEÍCULO 
    secaoA.carros.Add(uno); 

    //VERIFICANDO COM O USUÁRIO SE ELE DESEJA CONTINUAR OU SAIR
    Console.WriteLine("1 - PARA SAIR \n 0 - CONTINUAR \n");
    sair = int.Parse(Console.ReadLine());
 
   }
  
    // SOMAR OS VALORES DE TODOS OS CARROS
    double soma= 0;
    for(int i=0;i< secaoA.carros.Count;i++){
      soma +=secaoA.carros[i].getValor();

    }

     //EXIBINDO A SOMA TOTAL  
     Console.WriteLine("SOMA TOTAL calculaValor :  {0}",soma);


  } 

}