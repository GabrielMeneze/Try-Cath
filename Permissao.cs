using System;

namespace Try_Cath
{
    public class Permissao
    {
        
          
        private bool Acesso { get; set; }

        public void Autorizar(){

            
            try{

                Console.WriteLine("Acessar aplicação? True/False");
                Acesso = Boolean.Parse( Console.ReadLine() );
                if(Acesso == true){
                    System.Console.WriteLine("Bem vindo ao site");
                }else if(Acesso == false){
                    System.Console.WriteLine("Acesso interrompido");
                }
            }catch(Exception){

                Console.WriteLine("Erro nos dados inseridos, erro gerado");

            }

        }

        
    }
}