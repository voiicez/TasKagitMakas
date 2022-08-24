namespace TasKagitMakas.Models
{
     class El
    {
        Random _rastgele = new Random(); //field,alan
        public string[] Hareketler { get; } = new string[3]
        {
            "Kağıt","Taş","Makas"
        }; //property,özellik

        public string HareketOlustur() //behavior,davranış
        {
            int rastgeleIndex=_rastgele.Next(0, 3);
            return Hareketler[rastgeleIndex];
        }

        
    }
}
