using System;
using System.Text.RegularExpressions;

namespace PRFTLatam.DotNetWorkshop.Services.Models
{
    public class IdValidator{

        private String id;
      public IdValidator(String id){
          this.id=id;
      }

      public String getId(){
          return this.id;
      }

      public bool IsNullOrEmpty(){
            return String.IsNullOrEmpty(this.id) || String.IsNullOrWhiteSpace(this.id);
        }
        public bool isTheCharacterBetweenTheCorrectLength(){
            return !(this.id.Length >=10 && this.id.Length <= 32);
        }
        public bool IsHexadecimal(){
            Regex rgxHexa = new Regex("[a-fA-F0-9]{1,}$");
            MatchCollection match = rgxHexa.Matches(this.id);
            return match.Count == 0;
        }

    }
}