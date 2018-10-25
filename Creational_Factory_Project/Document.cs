using System.Collections.Generic;

namespace Creational_Factory_Project
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Position> _positions = new List<Position>();

        // Constructor calls abstract Factory method
        public Document()
        {
            CreatePositions();
        }

        public List<Position> GetPositions => _positions;

        // Factory Method
        public abstract void CreatePositions();
    }
}
