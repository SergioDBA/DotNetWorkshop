using System;
using System.Collections.Generic;
using PRFTLatam.DotNetWorkshop.Services.Models;

namespace PRFTLatam.DotNetWorkshop.Services.Logic
{
    public class ValidateId{
        private List<String> errors = new List<string>();
        private IdValidator idValidator;
        public void setIdentification (String id){
            idValidator = new IdValidator(id);
        }

        public String getIdentification (){
            return this.idValidator.getId();
        }

        public List<String> ValidateIdentification(){
            if(idValidator.IsNullOrEmpty()){
                this.errors.Add("The Id is empty");
                return errors;
            }
            if(idValidator.isTheCharacterBetweenTheCorrectLength()){
                this.errors.Add("The length is incorrect");
            }
            if(idValidator.IsHexadecimal()){
                this.errors.Add("Is not Hexadecimal");
            }
            return errors;
        }



    }
}