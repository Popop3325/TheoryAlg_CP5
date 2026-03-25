using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTheory_CP5
{
    using System.Collections.Generic;

    class Node
    {
        public string Name;
        public int Day;
        public int Month;
        public Node Next;

        public Node(string name, int day, int month)
        {
            this.Name = name;
            this.Day = day;
            this.Month = month;
            this.Next = null;
        }
    }

    class HashTable
    {
        private Node[] buckets;
        private int size = 366;
        private int hashType;

        public HashTable(int hashType)
        {
            this.hashType = hashType;
            this.buckets = new Node[size];
        }

        // Хеш-функція 1: Метод календарного згортання
        private int Hash1(int day, int month)
        {
            return ((month - 1) * 31 + (day - 1)) % size;
        }

        // Хеш-функція 2: Метод множення на просте число (Поліноміальна)
        private int Hash2(int day, int month)
        {
            return (day * 37 + month) % size;
        }

        private int GetIndex(int day, int month)
        {
            return (hashType == 1) ? Hash1(day, month) : Hash2(day, month);
        }

        public string Add(string name, int day, int month)
        {
            int index = GetIndex(day, month);
            Node newNode = new Node(name, day, month);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else // Вирішення колізій методом ланцюжків
            {
                Node current = buckets[index];
                while (current.Next != null)
                {
                    if (current.Name == name && current.Day == day) return "Вже є!";
                    current = current.Next;
                }
                current.Next = newNode;
            }
            return $"Успішно! Потрапило в розділ №{index}";
        }

        public string Remove(string name, int day, int month)
        {
            int index = GetIndex(day, month);
            Node current = buckets[index];
            Node prev = null;

            while (current != null)
            {
                if (current.Name == name && current.Day == day && current.Month == month)
                {
                    if (prev == null) buckets[index] = current.Next;
                    else prev.Next = current.Next;
                    return $"Видалено з бакета {index}";
                }
                prev = current;
                current = current.Next;
            }
            return "Не знайдено!";
        }

        public List<string> GetTable()
        {
            List<string> rows = new List<string>();
            for (int i = 0; i < size; i++)
            {
                if (buckets[i] != null)
                {
                    string info = $"Бакет {i}: ";
                    Node curr = buckets[i];
                    while (curr != null)
                    {
                        info += $"[{curr.Name} | {curr.Day}.{curr.Month}] -> ";
                        curr = curr.Next;
                    }
                    rows.Add(info + "null");
                }
            }
            return rows;
        }
    }
}