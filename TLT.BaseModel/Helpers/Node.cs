#region Used references

using System.Collections.Generic;

#endregion

namespace TLT.BaseModel.Helpers
{
   public class Node<T>
   {
      public Node (T value, IEnumerable<Node<T>> children) {
         Value = value;
         Children = new List<Node<T>> ( children );
      }

      public T Value { get; private set; }
      public IList<Node<T>> Children { get; private set; }
   }
}