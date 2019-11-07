using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_Categories
{
    public class Association
    {
        [Key]
        public int AssociationId{get;set;}
        public int ProductId{get;set;}
        public Product ProductDefinition{get;set;}
        public int CategoryId{get;set;}
        public Category CategoryDefinition{get;set;}
    }
}