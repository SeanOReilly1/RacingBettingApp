using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RaceBettingApp
{
    class ListOfRaces : ICollection<Races>
    {
        private List<Races> RaceList = new List<Races>();

        public int Count
        {
            get
            {
                return RaceList.Count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Races item)
        {
            RaceList.Add(item);
        }

        public void Clear()
        {
            RaceList.Clear();
        }

        public bool Contains(Races item)
        {
            return RaceList.Contains(item);
        }

        public void CopyTo(Races[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Races> GetEnumerator()
        {
            return RaceList.GetEnumerator();
        }

        public bool Remove(Races item)
        {
            return RaceList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
