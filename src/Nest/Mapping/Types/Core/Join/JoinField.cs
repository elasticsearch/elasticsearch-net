using System;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	// This does not extend from Union because its intended to be used on folk's _source's
	// And the union serialization will bleed into their own JSON.NET serializer should they
	// have one configured and then it will blow up because their contractresolver do not extend ours
	// from which we can snoop ConnectionSettings.
	//
	// ContractJsonResolverAttribute works as well but I rather keep this class contained as much as possible
	/// <summary>
	/// The field on which a parent-child relationship is joined
	/// </summary>
	[JsonFormatter(typeof(JoinFieldFormatter))]
	public class JoinField
	{
		internal readonly Child _child;
		internal readonly Parent _parent;
		internal readonly int _tag;

		public JoinField(Parent parentName)
		{
			_parent = parentName;
			_tag = 0;
		}

		public JoinField(Child child)
		{
			_child = child;
			_tag = 1;
		}

		public static JoinField Root<TParent>() => new Parent(typeof(TParent));

		public static JoinField Root(RelationName parent) => new Parent(parent);

		public static JoinField Link(RelationName child, Id parentId) => new Child(child, parentId);

		public static JoinField Link<TChild, TParentDocument>(TParentDocument parent) where TParentDocument : class =>
			new Child(typeof(TChild), Id.From<TParentDocument>(parent));

		public static JoinField Link<TChild>(Id parentId) => new Child(typeof(TChild), parentId);

		public static implicit operator JoinField(Parent parent) => new JoinField(parent);

		public static implicit operator JoinField(string parentName) => new JoinField(new Parent(parentName));

		public static implicit operator JoinField(Type parentType) => new JoinField(new Parent(parentType));

		public static implicit operator JoinField(Child child) => new JoinField(child);

		public T Match<T>(Func<Parent, T> first, Func<Child, T> second)
		{
			switch (_tag)
			{
				case 0:
					return first(_parent);
				case 1:
					return second(_child);
				default: throw new Exception($"Unrecognized tag value: {_tag}");
			}
		}

		public void Match(Action<Parent> first, Action<Child> second)
		{
			switch (_tag)
			{
				case 0:
					first(_parent);
					break;
				case 1:
					second(_child);
					break;
				default: throw new Exception($"Unrecognized tag value: {_tag}");
			}
		}

		public class Parent
		{
			public Parent(RelationName name) => Name = name;

			public RelationName Name { get; }
		}

		public class Child
		{
			public Child(RelationName name, Id parent)
			{
				Name = name;
				Parent = parent;
			}

			public RelationName Name { get; }
			public Id Parent { get; }
		}
	}
}
