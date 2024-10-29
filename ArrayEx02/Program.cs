int[] arrayNumero1 = {1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10};
int[] arrayNumero2 = {11 , 12 , 13 , 14 , 15 , 16 , 17 , 18 , 19 , 20};

for(int i = 0; i < arrayNumero1.Length; i++){

    if (i % 2 == 0){
        
    Console.WriteLine(arrayNumero1[i]);

    }else{

    Console.WriteLine(arrayNumero2[i]);

    }

}