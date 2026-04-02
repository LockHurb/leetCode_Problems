#Longest Common Prefix

contador = 0
semejantes = 0

listaStrings = ["cir","car"]

stringRepite = ""

if(len(listaStrings) == 0):

    print("")

else:

    for letra in listaStrings[0]:

        print("=============================================")
        print("Letra a evaluar: " + letra)

        for palabra in listaStrings:

            print("=============================================")
            print("Palabra a evaluar: "+ palabra)

            if contador >= len(palabra):

                break

            if palabra[contador] == letra:

                print("Se está comparando: " + palabra + " " + palabra[contador] + " " + letra)
                semejantes = semejantes + 1
                

        contador = contador + 1
        print(contador)

        if(len(listaStrings) == semejantes):
            stringRepite = stringRepite + letra
        else:
            break

        semejantes = 0
        print(stringRepite)

    
print("=============================================")
print(stringRepite)

#Solución más óptima

class Solution:
    def longestCommonPrefix(self, v: List[str]) -> str:
        ans=""
        v=sorted(v)
        first=v[0]
        last=v[-1]
        for i in range(min(len(first),len(last))):
            if(first[i]!=last[i]):
                return ans
            ans+=first[i]
        return ans 