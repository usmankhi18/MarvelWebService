using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RESTFulDemo
{
    public class CharactersResponse
    {
        [DataMember]
        public int status { get; set; }

        [DataMember]
        public List<Characters> CharactersArray { get; set; }
    }

    public class Characters
    {
        [DataMember]
        public int CharacterId { get; set; }

        [DataMember]
        public string CharacterName { get; set; }

        [DataMember]
        public string CharacterRealName { get; set; }

        [DataMember]
        public string CharacterLogo { get; set; }
    }
}
