﻿using System;
using System.Collections.Generic;
using System.Text;
using NBitcoin;
using NBXplorer.DerivationStrategy;

namespace NBXplorer.Models
{
	public class NewTransactionEvent
	{
		public uint256 BlockId
		{
			get; set;
		}

		public DerivationStrategyBase DerivationStrategy
		{
			get; set;
		}

		public TransactionResult TransactionData
		{
			get; set;
		}

		public List<KeyPathInformation> Outputs
		{
			get; set;
		} = new List<KeyPathInformation>();

		public List<KeyPathInformation> Inputs
		{
			get; set;
		} = new List<KeyPathInformation>();
		public string CryptoCode
		{
			get;
			set;
		}

		public TransactionMatch AsMatch()
		{
			return new TransactionMatch() { DerivationStrategy = DerivationStrategy, Inputs = Inputs, Outputs = Outputs, Transaction = TransactionData.Transaction };
		}
	}
}
