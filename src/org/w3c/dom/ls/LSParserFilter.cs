// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.ls {
public abstract class _iLSParserFilter {
public static short _fFILTER_1ACCEPT = 1;

public static short _fFILTER_1REJECT = 2;

public static short _fFILTER_1SKIP = 3;

public static short _fFILTER_1INTERRUPT = 4;


} // end of abstract class: _iLSParserFilter

public interface LSParserFilter {
 short startElement(global::org.w3c.dom.Element n1);

 short acceptNode(global::org.w3c.dom.Node n1);

 int getWhatToShow();

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.ls.LSParserFilter]
//XMLVM_END_WRAPPER[org.w3c.dom.ls.LSParserFilter]

} // end of interface: LSParserFilter

} // end of namespace: org.w3c.dom.ls
