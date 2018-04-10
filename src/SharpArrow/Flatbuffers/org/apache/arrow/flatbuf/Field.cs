// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace org.apache.arrow.flatbuf
{

using global::System;
using global::FlatBuffers;

/// ----------------------------------------------------------------------
/// A field represents a named column in a record / row batch or child of a
/// nested type.
///
/// - children is only for nested Arrow arrays
/// - For primitive types, children will have length 0
/// - nullable should default to true in general
public struct Field : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Field GetRootAsField(ByteBuffer _bb) { return GetRootAsField(_bb, new Field()); }
  public static Field GetRootAsField(ByteBuffer _bb, Field obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Field __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
  public bool Nullable { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FBType TypeType { get { int o = __p.__offset(8); return o != 0 ? (FBType)__p.bb.Get(o + __p.bb_pos) : FBType.NONE; } }
  public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(10); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }
  public DictionaryEncoding? Dictionary { get { int o = __p.__offset(12); return o != 0 ? (DictionaryEncoding?)(new DictionaryEncoding()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Field? Children(int j) { int o = __p.__offset(14); return o != 0 ? (Field?)(new Field()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ChildrenLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public KeyValue? CustomMetadata(int j) { int o = __p.__offset(16); return o != 0 ? (KeyValue?)(new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CustomMetadataLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Field> CreateField(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      bool nullable = false,
      FBType type_type = FBType.NONE,
      int typeOffset = 0,
      Offset<DictionaryEncoding> dictionaryOffset = default(Offset<DictionaryEncoding>),
      VectorOffset childrenOffset = default(VectorOffset),
      VectorOffset custom_metadataOffset = default(VectorOffset)) {
    builder.StartObject(7);
    Field.AddCustomMetadata(builder, custom_metadataOffset);
    Field.AddChildren(builder, childrenOffset);
    Field.AddDictionary(builder, dictionaryOffset);
    Field.AddType(builder, typeOffset);
    Field.AddName(builder, nameOffset);
    Field.AddTypeType(builder, type_type);
    Field.AddNullable(builder, nullable);
    return Field.EndField(builder);
  }

  public static void StartField(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddNullable(FlatBufferBuilder builder, bool nullable) { builder.AddBool(1, nullable, false); }
  public static void AddTypeType(FlatBufferBuilder builder, FBType typeType) { builder.AddByte(2, (byte)typeType, 0); }
  public static void AddType(FlatBufferBuilder builder, int typeOffset) { builder.AddOffset(3, typeOffset, 0); }
  public static void AddDictionary(FlatBufferBuilder builder, Offset<DictionaryEncoding> dictionaryOffset) { builder.AddOffset(4, dictionaryOffset.Value, 0); }
  public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset) { builder.AddOffset(5, childrenOffset.Value, 0); }
  public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, Offset<Field>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartChildrenVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCustomMetadata(FlatBufferBuilder builder, VectorOffset customMetadataOffset) { builder.AddOffset(6, customMetadataOffset.Value, 0); }
  public static VectorOffset CreateCustomMetadataVector(FlatBufferBuilder builder, Offset<KeyValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartCustomMetadataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Field> EndField(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Field>(o);
  }
};


}