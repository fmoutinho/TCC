using IndexManager.Model;
using IndexManager.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexManager.Core.Services
{
    public class IndexService
    {

        public void CreateIndexes(Table table)
        {
            List<String> IndexNames = new List<string>();
            List<String> IndexMembers = new List<string>();

            GenerateNewIndexMembers(IndexNames, table, "", 0);
            GenerateNewIndexNames(IndexNames, table ,"", 0);
            for (String palavra : resultado)
            {
                System.out.println(palavra);
            }
        }
        public void GenerateNewIndexMembers(List<String> indexMembers, Table table, String combination, int usedColumns)
        {
            String currentCombination = combination;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                currentCombination = string.Concat(currentCombination ," , ", table.Columns.ElementAt(i).Name);

                if (palavraCorrente.length() >= palavra.length())
                {
                    resultado.add(palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
                else
                {
                    resultado.add(palavraCorrente);
                    geraNovaPalavra(resultado, palavra, palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
            }
        }

        public void GenerateNewIndexNames(List<String> indexMembers, Table table, String combination, int usedColumns)
        {
            String palavraCorrente = palavraAtual;
            for (int i = 0; i < palavra.length(); i++)
            {
                palavraCorrente += palavra.charAt(i);
                if (palavraCorrente.length() >= palavra.length())
                {
                    resultado.add(palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
                else
                {
                    resultado.add(palavraCorrente);
                    geraNovaPalavra(resultado, palavra, palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
            }
        }
    }
}
