using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * This class represents a collection of registered members in the library.
     * 
     * Author: Phuong Nam Ly May 2020
     */
    public class MemberCollection
    {
        private Member[] memberCo;
        private int memberNum = 0;

        public MemberCollection()
        {
            memberCo = new Member[10]; 
        }

        public void Add(String firstName, String lastName, String address, int phoneNum, int password)
        {
            memberCo[memberNum] = new Member(firstName, lastName, address, phoneNum, password);
            memberNum += 1;
        }

        public bool Search(String username, int password)
        {
            foreach(Member m in memberCo)
            {
                if (m != null)
                {
                    if (username == m.UserName && password == m.Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Search(String username)
        {
            foreach (Member m in memberCo)
            {
                if (m != null)
                {
                    if (username == m.UserName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public Member GetMember(String username)
        {
            foreach (Member m in memberCo)
            {
                if (username == m.UserName)
                {
                    return m;
                }
            }

            return null;
        }

        public Member GetMember(int phoneNum)
        {
            foreach (Member m in memberCo)
            {
                if (phoneNum == m.PhoneNum)
                {
                    return m;
                }
            }

            return null;
        }
    }
}
