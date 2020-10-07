using System;

//CONSTRUTOR COMPLETO


class Veiculo{
  //coloquei o valor dos parametros para teste
   string marca; 
   int ano,km;


 double valor;

  public double getValor(){
    return valor;
  }

public void relatorio(){


  Console.WriteLine("MARCA : {0} \n ANO : {1} \n KM :{2} \n VALOR {3} \n",marca,ano,km,valor );

}

public void atualizaValor(int a,int aFab,double valorAterior){

  double novo_valor = valorAterior - (a - aFab) * 2.05;
  Console.WriteLine("NOVO VALOR " + novo_valor);
  
}

//CONTRUTOR COMPLETO
public Veiculo(string m, int a,int k,double v){

  marca = m;
  ano = a;
  km = km;
  valor = v;


}



}