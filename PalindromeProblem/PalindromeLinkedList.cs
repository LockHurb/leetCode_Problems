using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.Net;

class Palindrome()
{
    
    public static void Main(string[] args)
    {
        
        ListNode lista = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(1))));


        Console.WriteLine(lista.next.next.next.val);
        Console.WriteLine(isPalindrome(lista));

    }

    public static bool isPalindrome(ListNode head)
    {

        ListNode temp = head;
        int contador = 0;
        List<int> numeros = new List<int>();
        List<int> validator = new List<int>();
        while(temp != null)
        {
            int valor = temp.val;
            numeros.Add(valor);
            temp = temp.next;
        }
        foreach(int num in numeros) validator.Add(num);
        numeros.Reverse();
        foreach(int v in validator)
        {
            if (v != numeros[contador]) return false;
            contador++;
        }
        return true;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}