using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace wms_server_list
{
	public class WMS_server : Altova.Xml.Node
	{
		#region Forward constructors
		public WMS_server() : base() { SetCollectionParents(); }
		public WMS_server(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public WMS_server(XmlNode node) : base(node) { SetCollectionParents(); }
		public WMS_server(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Name"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Name", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "ServerUrl"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "ServerUrl", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Version"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Version", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "UserName"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "UserName", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Password"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Password", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Abstract"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Abstract", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		#region Name accessor methods
		public int GetNameMinCount()
		{
			return 1;
		}

		public int NameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNameMaxCount()
		{
			return 1;
		}

		public int NameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNameCount()
		{
			return DomChildCount(NodeType.Element, "", "Name");
		}

		public int NameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Name");
			}
		}

		public bool HasName()
		{
			return HasDomChild(NodeType.Element, "", "Name");
		}

		public SchemaString GetNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Name", index)));
		}

		public SchemaString GetName()
		{
			return GetNameAt(0);
		}

		public SchemaString Name
		{
			get
			{
				return GetNameAt(0);
			}
		}

		public void RemoveNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Name", index);
		}

		public void RemoveName()
		{
			while (HasName())
				RemoveNameAt(0);
		}

		public void AddName(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Name", newValue.ToString());
		}

		public void InsertNameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Name", index, newValue.ToString());
		}

		public void ReplaceNameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Name", index, newValue.ToString());
		}
		#endregion // Name accessor methods

		#region Name collection
        public NameCollection	MyNames = new NameCollection( );

        public class NameCollection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public NameEnumerator GetEnumerator() 
			{
				return new NameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NameEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public NameEnumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.NameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetNameAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Name collection

		#region ServerUrl accessor methods
		public int GetServerUrlMinCount()
		{
			return 1;
		}

		public int ServerUrlMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlMaxCount()
		{
			return 1;
		}

		public int ServerUrlMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlCount()
		{
			return DomChildCount(NodeType.Element, "", "ServerUrl");
		}

		public int ServerUrlCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ServerUrl");
			}
		}

		public bool HasServerUrl()
		{
			return HasDomChild(NodeType.Element, "", "ServerUrl");
		}

		public SchemaString GetServerUrlAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ServerUrl", index)));
		}

		public SchemaString GetServerUrl()
		{
			return GetServerUrlAt(0);
		}

		public SchemaString ServerUrl
		{
			get
			{
				return GetServerUrlAt(0);
			}
		}

		public void RemoveServerUrlAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ServerUrl", index);
		}

		public void RemoveServerUrl()
		{
			while (HasServerUrl())
				RemoveServerUrlAt(0);
		}

		public void AddServerUrl(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "ServerUrl", newValue.ToString());
		}

		public void InsertServerUrlAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}

		public void ReplaceServerUrlAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}
		#endregion // ServerUrl accessor methods

		#region ServerUrl collection
        public ServerUrlCollection	MyServerUrls = new ServerUrlCollection( );

        public class ServerUrlCollection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public ServerUrlEnumerator GetEnumerator() 
			{
				return new ServerUrlEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ServerUrlEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public ServerUrlEnumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.ServerUrlCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetServerUrlAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // ServerUrl collection

		#region Version accessor methods
		public int GetVersionMinCount()
		{
			return 1;
		}

		public int VersionMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetVersionMaxCount()
		{
			return 1;
		}

		public int VersionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetVersionCount()
		{
			return DomChildCount(NodeType.Element, "", "Version");
		}

		public int VersionCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Version");
			}
		}

		public bool HasVersion()
		{
			return HasDomChild(NodeType.Element, "", "Version");
		}

		public SchemaString GetVersionAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Version", index)));
		}

		public SchemaString GetVersion()
		{
			return GetVersionAt(0);
		}

		public SchemaString Version
		{
			get
			{
				return GetVersionAt(0);
			}
		}

		public void RemoveVersionAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Version", index);
		}

		public void RemoveVersion()
		{
			while (HasVersion())
				RemoveVersionAt(0);
		}

		public void AddVersion(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Version", newValue.ToString());
		}

		public void InsertVersionAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Version", index, newValue.ToString());
		}

		public void ReplaceVersionAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Version", index, newValue.ToString());
		}
		#endregion // Version accessor methods

		#region Version collection
        public VersionCollection	MyVersions = new VersionCollection( );

        public class VersionCollection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public VersionEnumerator GetEnumerator() 
			{
				return new VersionEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class VersionEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public VersionEnumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.VersionCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetVersionAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Version collection

		#region UserName accessor methods
		public int GetUserNameMinCount()
		{
			return 0;
		}

		public int UserNameMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetUserNameMaxCount()
		{
			return 1;
		}

		public int UserNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetUserNameCount()
		{
			return DomChildCount(NodeType.Element, "", "UserName");
		}

		public int UserNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "UserName");
			}
		}

		public bool HasUserName()
		{
			return HasDomChild(NodeType.Element, "", "UserName");
		}

		public SchemaString GetUserNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "UserName", index)));
		}

		public SchemaString GetUserName()
		{
			return GetUserNameAt(0);
		}

		public SchemaString UserName
		{
			get
			{
				return GetUserNameAt(0);
			}
		}

		public void RemoveUserNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "UserName", index);
		}

		public void RemoveUserName()
		{
			while (HasUserName())
				RemoveUserNameAt(0);
		}

		public void AddUserName(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "UserName", newValue.ToString());
		}

		public void InsertUserNameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "UserName", index, newValue.ToString());
		}

		public void ReplaceUserNameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "UserName", index, newValue.ToString());
		}
		#endregion // UserName accessor methods

		#region UserName collection
        public UserNameCollection	MyUserNames = new UserNameCollection( );

        public class UserNameCollection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public UserNameEnumerator GetEnumerator() 
			{
				return new UserNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class UserNameEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public UserNameEnumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.UserNameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetUserNameAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // UserName collection

		#region Password accessor methods
		public int GetPasswordMinCount()
		{
			return 0;
		}

		public int PasswordMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetPasswordMaxCount()
		{
			return 1;
		}

		public int PasswordMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetPasswordCount()
		{
			return DomChildCount(NodeType.Element, "", "Password");
		}

		public int PasswordCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Password");
			}
		}

		public bool HasPassword()
		{
			return HasDomChild(NodeType.Element, "", "Password");
		}

		public SchemaString GetPasswordAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Password", index)));
		}

		public SchemaString GetPassword()
		{
			return GetPasswordAt(0);
		}

		public SchemaString Password
		{
			get
			{
				return GetPasswordAt(0);
			}
		}

		public void RemovePasswordAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Password", index);
		}

		public void RemovePassword()
		{
			while (HasPassword())
				RemovePasswordAt(0);
		}

		public void AddPassword(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Password", newValue.ToString());
		}

		public void InsertPasswordAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Password", index, newValue.ToString());
		}

		public void ReplacePasswordAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Password", index, newValue.ToString());
		}
		#endregion // Password accessor methods

		#region Password collection
        public PasswordCollection	MyPasswords = new PasswordCollection( );

        public class PasswordCollection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public PasswordEnumerator GetEnumerator() 
			{
				return new PasswordEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class PasswordEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public PasswordEnumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.PasswordCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetPasswordAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Password collection

		#region Abstract2 accessor methods
		public int GetAbstract2MinCount()
		{
			return 0;
		}

		public int Abstract2MinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetAbstract2MaxCount()
		{
			return 1;
		}

		public int Abstract2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetAbstract2Count()
		{
			return DomChildCount(NodeType.Element, "", "Abstract");
		}

		public int Abstract2Count
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Abstract");
			}
		}

		public bool HasAbstract2()
		{
			return HasDomChild(NodeType.Element, "", "Abstract");
		}

		public SchemaString GetAbstract2At(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Abstract", index)));
		}

		public SchemaString GetAbstract2()
		{
			return GetAbstract2At(0);
		}

		public SchemaString Abstract2
		{
			get
			{
				return GetAbstract2At(0);
			}
		}

		public void RemoveAbstract2At(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Abstract", index);
		}

		public void RemoveAbstract2()
		{
			while (HasAbstract2())
				RemoveAbstract2At(0);
		}

		public void AddAbstract2(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Abstract", newValue.ToString());
		}

		public void InsertAbstract2At(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Abstract", index, newValue.ToString());
		}

		public void ReplaceAbstract2At(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Abstract", index, newValue.ToString());
		}
		#endregion // Abstract2 accessor methods

		#region Abstract2 collection
        public Abstract2Collection	MyAbstract2s = new Abstract2Collection( );

        public class Abstract2Collection: IEnumerable
        {
            WMS_server parent;
            public WMS_server Parent
			{
				set
				{
					parent = value;
				}
			}
			public Abstract2Enumerator GetEnumerator() 
			{
				return new Abstract2Enumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class Abstract2Enumerator: IEnumerator 
        {
			int nIndex;
			WMS_server parent;
			public Abstract2Enumerator(WMS_server par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.Abstract2Count );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetAbstract2At(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Abstract2 collection

        private void SetCollectionParents()
        {
            MyNames.Parent = this; 
            MyServerUrls.Parent = this; 
            MyVersions.Parent = this; 
            MyUserNames.Parent = this; 
            MyPasswords.Parent = this; 
            MyAbstract2s.Parent = this; 
	}
}
}