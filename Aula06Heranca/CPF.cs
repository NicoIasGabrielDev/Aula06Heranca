namespace Aula06Heranca
{
    public class cpf:Pessoa
    {
      public string CPF;
      public string rg;
      public bool Validarcpf(){
      if( CPF!= ""){
      return true; 
      }
      return false;
      }
    }
    
    
        
    
}