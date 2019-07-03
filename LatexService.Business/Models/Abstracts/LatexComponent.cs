using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LatexService.Business.Models.Abstracts
{
    public abstract class LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        protected Dictionary<string, string> attributes = new Dictionary<string, string>();
        public string RawData { get; protected set; }
        public string Data { get; protected set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public LatexComponent()
        { }

        public LatexComponent(string filePath)
        {
            LoadFromFile(filePath);
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        private void SetValue(string variableName, string value)
        {
            Data = Data.Replace(variableName, value);
        }

        protected void CheckCreateAttribute(string attributeName)
        {
            if (attributes.ContainsKey(attributeName) == false)
                attributes.Add(attributeName, attributeName);
        }

        public void LoadFromFile(string filePath)
        {
            RawData = File.ReadAllText(filePath, Encoding.UTF8);
            Data = RawData;
            Compile();
        }

        public override string ToString()
        {
            Compile();

            return (Data);
        }

        public virtual void Compile()
        {
            Data = RawData;

            foreach (KeyValuePair<string, string> item in attributes)
                SetValue(item.Key, item.Value);
        }

        #endregion ==================== METHODS ====================
    }
}