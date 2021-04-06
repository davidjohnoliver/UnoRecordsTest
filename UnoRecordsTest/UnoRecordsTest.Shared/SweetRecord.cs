using System;
using System.Collections.Generic;
using System.Text;

namespace UnoRecordsTest
{
	public record SweetRecord(
		bool IsChecked,
		string RecordedMessage
	)
	{
	}
}
