﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Util
{
    public static class Constants
    {
        public static readonly string Literal = @"([\w\d-()]+)";
        public static readonly string NamedLiteral = @"(?<literal>[\w\d-()]+)";
        public static readonly string OptSpaces = @" *";
        public static readonly string OptNewLine = @"[ \n\r]*";

        public static readonly string Or = @"|";

        public static readonly RegexOptions CompiledMultilineCaseInsensitive = RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase;

        public static readonly RegexOptions CompiledCaseInsensitive = RegexOptions.Compiled | RegexOptions.IgnoreCase;

        public static readonly string StatementsBeforeOutputLiteral = @"((?<beforeOutput>INTO|TO) +)";

        public static readonly string StatementsBeforeInputLiteralSpaceMandatory = @"((?<beforeInputWithSpace>MOVE|DIVIDE|ADD|SUBTRACT|MULTIPLY|SET|IF|AND|OR|THAN|GIVING|REMAINDER|NOT|BY|UNTIL) +)";

        public static readonly string StatementsBeforeInputLiteralSpaceOptional = @"((?<beforeInput>=|<|>) *)";

        public static readonly string LiteralWithInputOutput = "(" + StatementsBeforeOutputLiteral + Or + StatementsBeforeInputLiteralSpaceMandatory
            + Or + StatementsBeforeInputLiteralSpaceOptional + ")" + NamedLiteral;

        public static readonly string StatementsAfterInputLiteralSpaceMandatory = @"( +(?<afterInputWithSpace>TO|AND|OR|GREATER|LESS|BY|GIVING|REMAINDER|NOT))";

        public static readonly string StatementsAfterInputLiteralSpaceOptional = @"( *(?<afterInput>\.|=|<|>))";

        public static readonly string Perform = @"PERFORM (" + NamedLiteral + @") ?(THRU|UNTIL|WITH)? ?" + Literal + @"? ?(UNTIL|BEFORE|AFTER)? ?(" + Literal + @"|[<>=]|)";

        public static readonly string GoTo = @" GO TO +" + NamedLiteral;

        public static readonly string Call = @"CALL +""" + NamedLiteral + @""" +(USING (" + Literal + ",? ?)*)?"; // TODO multiline calls

        public static readonly string Copy = @" *COPY (?<program>[\w]+) +OF +(?<folder>[\w]+)\.";

        public static readonly string CopyWithoutFolder = @" *COPY (?<program>[\w]+)\.";

        private static readonly string VarLevel = @"^[ ]+(?<level>\d\d)";

        private static readonly string VarRedefines = @"(REDEFINES *(?<redefines>[\w\d-()]+))?";

        private static readonly string VarPicture = @"(BINARY|PIC(TURE)? (IS )?(-*\.-*)?(?<type>(X|9|S|V|-|,|\(\d+\))+) *(?<comp>COMP(UTATIONAL)?(-\d)?)?)?";

        private static readonly string VarValue = @"((VALUE(S)?) (IS |ARE )?(?<value>(""[^""]+""|(\d*\.)?\d+|SPACE(S)?|ZERO(E)?(S)?|(HIGH-|LOW-)VALUES| +THROUGH +| +THRU +|, *|\n|\r| )*))?";

        private static readonly string VarOccurs = @"(OCCURS (?<occurs>\d+))?";

        public static readonly string Variable = VarLevel + OptSpaces + NamedLiteral + OptNewLine + VarRedefines + OptNewLine + VarPicture + OptNewLine + VarValue + OptNewLine + VarOccurs + OptNewLine + @"\.";

        public static readonly Regex SectionRegex = new Regex(@"^.{6} (?<sectionName>[\w\d-]+ SECTION)\.", RegexOptions.Compiled | RegexOptions.Multiline);

        public static readonly Regex ProcedureRegex = new Regex(@"^.{6} (?<procedureName>[\w\d-]+)\.", RegexOptions.Compiled | RegexOptions.Multiline);

        public static readonly HashSet<string> CobolKeywords = new HashSet<string>
        {
            "ACCEPT",
            "ACCESS",
            "ADD",
            "ADDRESS",
            "ADVANCING",
            "AFTER",
            "ALL",
            "ALPHABET",
            "ALPHABETIC",
            "ALPHABETIC-LOWER",
            "ALPHABETIC-UPPER",
            "ALPHANUMERIC",
            "ALPHANUMERIC-EDITED",
            "ALSO",
            "ALTER",
            "ALTERNATE",
            "AND",
            "ANY",
            "APPLY",
            "ARE",
            "AREA",
            "AREAS",
            "ASCENDING",
            "ASSIGN",
            "AT",
            "AUTHOR",
            "BASIS",
            "BEFORE",
            "BEGINNING",
            "BINARY",
            "BLANK",
            "BLOCK",
            "BOTTOM",
            "BY",
            "CALL",
            "CANCEL",
            "CBL",
            "CD",
            "CF",
            "CH",
            "CHARACTER",
            "CHARACTERS",
            "CLASS",
            "CLASS-ID",
            "CLOCK-UNITS",
            "CLOSE",
            "COBOL",
            "CODE",
            "CODE-SET",
            "COLLATING",
            "COLUMN",
            "COM-REG",
            "COMMA",
            "COMMON",
            "COMMUNICATION",
            "COMP",
            "COMP-1",
            "COMP-2",
            "COMP-3",
            "COMP-4",
            "COMP-5",
            "COMPUTATIONAL",
            "COMPUTATIONAL-1",
            "COMPUTATIONAL-2",
            "COMPUTATIONAL-3",
            "COMPUTATIONAL-4",
            "COMPUTATIONAL-5",
            "COMPUTE",
            "CONFIGURATION",
            "CONTAINS",
            "CONTENT",
            "CONTINUE",
            "CONTROL",
            "CONTROLS",
            "CONVERTING",
            "COPY",
            "CORR",
            "CORRESPONDING",
            "COUNT",
            "CURRENCY",
            "DATA",
            "DATE-COMPILED",
            "DATE-WRITTEN",
            "DAY",
            "DAY-OF-WEEK",
            "DBCS",
            "DE",
            "DEBUG-CONTENTS",
            "DEBUG-ITEM",
            "DEBUG-LINE",
            "DEBUG-NAME",
            "DEBUG-SUB-1",
            "DEBUG-SUB-2",
            "DEBUG-SUB-3",
            "DEBUGGING",
            "DECIMAL-POINT",
            "DECLARATIVES",
            "DELETE",
            "DELIMITED",
            "DELIMITER",
            "DEPENDING",
            "DESCENDING",
            "DESTINATION",
            "DETAIL",
            "DISPLAY",
            "DISPLAY-1",
            "DIVIDE",
            "DIVISION",
            "DOWN",
            "DUPLICATES",
            "DYNAMIC",
            "EGCS",
            "EGI",
            "EJECT",
            "ELSE",
            "EMI",
            "ENABLE",
            "END",
            "END-ADD",
            "END-CALL",
            "END-COMPUTE",
            "END-DELETE",
            "END-DIVIDE",
            "END-EVALUATE",
            "END-IF",
            "END-INVOKE",
            "END-MULTIPLY",
            "END-OF-PAGE",
            "END-PERFORM",
            "END-READ",
            "END-RECEIVE",
            "END-RETURN",
            "END-REWRITE",
            "END-SEARCH",
            "END-START",
            "END-STRING",
            "END-SUBTRACT",
            "END-UNSTRING",
            "END-WRITE",
            "ENDING",
            "ENTER",
            "ENTRY",
            "ENVIRONMENT",
            "EOP",
            "EQUAL",
            "ERROR",
            "ESI",
            "EVALUATE",
            "EVERY",
            "EXCEPTION",
            "EXIT",
            "EXTEND",
            "EXTERNAL",
            "FALSE",
            "FD",
            "FILE",
            "FILE-CONTROL",
            "FILLER",
            "FINAL",
            "FIRST",
            "FOOTING",
            "FOR",
            "FROM",
            "FUNCTION",
            "GENERATE",
            "GIVING",
            "GLOBAL",
            "GO",
            "GOBACK",
            "GREATER",
            "GROUP",
            "HEADING",
            "HIGH-VALUE",
            "HIGH-VALUES",
            "I-O",
            "I-O-CONTROL",
            "ID",
            "IDENTIFICATION",
            "IF",
            "IN",
            "INDEX",
            "INDEXED",
            "INDICATE",
            "INHERITS",
            "INITIAL",
            "INITIALIZE",
            "INITIATE",
            "INPUT",
            "INPUT-OUTPUT",
            "INSERT",
            "INSPECT",
            "INSTALLATION",
            "INTO",
            "INVALID",
            "INVOKE",
            "IS",
            "JUST",
            "JUSTIFIED",
            "KANJI",
            "KEY",
            "LABEL",
            "LAST",
            "LEADING",
            "LEFT",
            "LENGTH",
            "LESS",
            "LIMIT",
            "LIMITS",
            "LINAGE",
            "LINAGE-COUNTER",
            "LINE",
            "LINE-COUNTER",
            "LINES",
            "LINKAGE",
            "LOCAL-STORAGE",
            "LOCK",
            "LOW-VALUE",
            "LOW-VALUES",
            "MEMORY",
            "MERGE",
            "MESSAGE",
            "METACLASS",
            "METHOD",
            "METHOD-ID",
            "MODE",
            "MODULES",
            "MORE-LABELS",
            "MOVE",
            "MULTIPLE",
            "MULTIPLY",
            "NATIVE",
            "NATIVE_BINARY",
            "NEGATIVE",
            "NEXT",
            "NO",
            "NOT",
            "NULL",
            "NULLS",
            "NUMBER",
            "NUMERIC",
            "NUMERIC-EDITED",
            "OBJECT",
            "OBJECT-COMPUTER",
            "OCCURS",
            "OF",
            "OFF",
            "OMITTED",
            "ON",
            "OPEN",
            "OPTIONAL",
            "OR",
            "ORDER",
            "ORGANIZATION",
            "OTHER",
            "OUTPUT",
            "OVERFLOW",
            "OVERRIDE",
            "PACKED-DECIMAL",
            "PADDING",
            "PAGE",
            "PAGE-COUNTER",
            "PASSWORD",
            "PERFORM",
            "PF",
            "PH",
            "PIC",
            "PICTURE",
            "PLUS",
            "POINTER",
            "POSITION",
            "POSITIVE",
            "PRINTING",
            "PROCEDURE",
            "PROCEDURE-POINTER",
            "PROCEDURES",
            "PROCEED",
            "PROCESSING",
            "PROGRAM",
            "PROGRAM-ID",
            "PURGE",
            "QUEUE",
            "QUOTE",
            "QUOTES",
            "RANDOM",
            "RD",
            "READ",
            "READY",
            "RECEIVE",
            "RECORD",
            "RECORDING",
            "RECORDS",
            "RECURSIVE",
            "REDEFINES",
            "REEL",
            "REFERENCE",
            "REFERENCES",
            "RELATIVE",
            "RELEASE",
            "RELOAD",
            "REMAINDER",
            "REMOVAL",
            "RENAMES",
            "REPLACE",
            "REPLACING",
            "REPORT",
            "REPORTING",
            "REPORTS",
            "REPOSITORY",
            "RERUN",
            "RESERVE",
            "RESET",
            "RETURN",
            "RETURN-CODE",
            "RETURNING",
            "REVERSED",
            "REWIND",
            "REWRITE",
            "RF",
            "RH",
            "RIGHT",
            "ROUNDED",
            "RUN",
            "SAME",
            "SD",
            "SEARCH",
            "SECTION",
            "SECURITY",
            "SEGMENT",
            "SEGMENT-LIMIT",
            "SELECT",
            "SELF",
            "SEND",
            "SENTENCE",
            "SEPARATE",
            "SEQUENCE",
            "SEQUENTIAL",
            "SERVICE",
            "SET",
            "SHIFT-IN",
            "SHIFT-OUT",
            "SIGN",
            "SIZE",
            "SKIP1",
            "SKIP2",
            "SKIP3",
            "SORT",
            "SORT-CONTROL",
            "SORT-CORE-SIZE",
            "SORT-FILE-SIZE",
            "SORT-MERGE",
            "SORT-MESSAGE",
            "SORT-MODE-SIZE",
            "SORT-RETURN",
            "SOURCE",
            "SOURCE-COMPUTER",
            "SPACE",
            "SPACES",
            "SPECIAL-NAMES",
            "STANDARD",
            "STANDARD-1",
            "STANDARD-2",
            "START",
            "STATUS",
            "STOP",
            "STRING",
            "SUB-QUEUE-1",
            "SUB-QUEUE-2",
            "SUB-QUEUE-3",
            "SUBTRACT",
            "SUM",
            "SUPER",
            "SUPPRESS",
            "SYMBOLIC",
            "SYNC",
            "SYNCHRONIZED",
            "TABLE",
            "TALLY",
            "TALLYING",
            "TAPE",
            "TERMINAL",
            "TERMINATE",
            "TEST",
            "TEXT",
            "THAN",
            "THEN",
            "THROUGH",
            "THRU",
            "TIME",
            "TIMES",
            "TITLE",
            "TO",
            "TOP",
            "TRACE",
            "TRAILING",
            "TRUE",
            "TYPE",
            "UNIT",
            "UNSTRING",
            "UNTIL",
            "UP",
            "UPON",
            "USAGE",
            "USE",
            "USING",
            "VALUE",
            "VALUES",
            "VARYING",
            "WHEN",
            "WHEN-COMPILED",
            "WITH",
            "WORDS",
            "WORKING-STORAGE",
            "WRITE",
            "WRITE-ONLY",
            "ZERO",
            "ZEROES",
            "ZEROS"
        };
    }
}
