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
        public string BirthDate;
        public Node Next;

        public Node(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            Next = null;
        }
    }

    class HashTable
    {
        private Node[] buckets;
        private int size;
        private int hashType;

        public HashTable(int size, int hashType)
        {
            this.size = size;
            this.hashType = hashType;
            buckets = new Node[size];
        }

        private int Hash1(string key)
        {
            int sum = 0;
            foreach (char c in key)
                sum += (int)c;
            return sum % size;
        }

        private int Hash2(string key)
        {
            int hash = 0;
            int p = 31;
            int power = 1;
            foreach (char c in key)
            {
                hash = (hash + (int)c * power) % size;
                power = (power * p) % size;
            }
            return hash;
        }

        private int GetHash(string key)
        {
            return (hashType == 1) ? Hash1(key) : Hash2(key);
        }

        public string Add(string name, string birthDate)
        {
            int index = GetHash(name);
            Node newNode = new Node(name, birthDate);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                Node current = buckets[index];
                while (current.Next != null)
                {
                    if (current.Name == name && current.BirthDate == birthDate)
                        return "Такий запис вже існує!";
                    current = current.Next;
                }
                if (current.Name == name && current.BirthDate == birthDate)
                    return "Такий запис вже існує!";
                current.Next = newNode;
            }

            return $"Додано в бакет [{index}]";
        }

        public string Remove(string name, string birthDate)
        {
            int index = GetHash(name);
            Node current = buckets[index];
            Node previous = null;

            while (current != null)
            {
                if (current.Name == name && current.BirthDate == birthDate)
                {
                    if (previous == null)
                        buckets[index] = current.Next;
                    else
                        previous.Next = current.Next;

                    return $"Видалено з бакету [{index}]";
                }
                previous = current;
                current = current.Next;
            }

            return "Запис не знайдено!";
        }

        public List<string> GetTable()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < size; i++)
            {
                if (buckets[i] == null)
                {
                    result.Add($"Бакет [{i}]: порожньо");
                }
                else
                {
                    string row = $"Бакет [{i}]: ";
                    Node current = buckets[i];
                    while (current != null)
                    {
                        row += $"{current.Name} ({current.BirthDate})";
                        if (current.Next != null)
                            row += " → ";
                        current = current.Next;
                    }
                    result.Add(row);
                }
            }

            return result;
        }
    }
}