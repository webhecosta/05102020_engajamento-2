using System;

class Vendedor {

double salario,comissao;
string nome;

//ALTERAR CONTEUDO
public void setNome(string n){
  nome = n;

}
//SOMENTE EXIBIR O CONTEUDO
public string getNome(){

  return nome;
}


public double receberSalario(double valorVendas,double com,double sal){
  double total = sal + (com * valorVendas);
  return total;

}

//CONSTRUTOR COMPLETO
public Vendedor(string n,double s,double c){

  nome = n;
  salario = s;
  comissao = c;


}

}