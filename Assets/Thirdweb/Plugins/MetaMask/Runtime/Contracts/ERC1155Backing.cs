//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : MetaMask Unity SDK ABI Code Generator
//   Input filename:  ERC1155.sol
//   Output filename: ERC1155Backing.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------

#if UNITY_EDITOR || !ENABLE_MONO
using System;
using System.Numerics;
using System.Threading.Tasks;
using evm.net;
using evm.net.Models;

namespace MetaMask.Contracts
{
	public class ERC1155Backing : Contract, ERC1155
	{
		public new string Address
		{
			get => base.Address;
		}
		public ERC1155Backing(IProvider provider, EvmAddress address, Type interfaceType) : base(provider, address, interfaceType)
		{
		}
		public Task<ERC1155> DeployNew(String uri_)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<ERC1155>) InvokeMethod(method, new object[] { uri_ });
		}
		
		[EvmMethodInfo(Name = "balanceOf", View = true)]
		public Task<BigInteger> BalanceOf(EvmAddress account, BigInteger id)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<BigInteger>) InvokeMethod(method, new object[] { account, id });
		}
		
		[EvmMethodInfo(Name = "balanceOfBatch", View = true)]
		public Task<BigInteger[]> BalanceOfBatch(EvmAddress[] accounts, BigInteger[] ids)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<BigInteger[]>) InvokeMethod(method, new object[] { accounts, ids });
		}
		
		[EvmMethodInfo(Name = "isApprovedForAll", View = true)]
		public Task<Boolean> IsApprovedForAll(EvmAddress account, [EvmParameterInfo(Type = "address", Name = "operator")] EvmAddress @operator)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<Boolean>) InvokeMethod(method, new object[] { account, @operator });
		}
		
		[EvmMethodInfo(Name = "safeBatchTransferFrom", View = false)]
		public Task<Transaction> SafeBatchTransferFrom(EvmAddress from, EvmAddress to, BigInteger[] ids, BigInteger[] amounts, Byte[] data)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<Transaction>) InvokeMethod(method, new object[] { from, to, ids, amounts, data });
		}
		
		[EvmMethodInfo(Name = "safeTransferFrom", View = false)]
		public Task<Transaction> SafeTransferFrom(EvmAddress from, EvmAddress to, BigInteger id, BigInteger amount, Byte[] data)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<Transaction>) InvokeMethod(method, new object[] { from, to, id, amount, data });
		}
		
		[EvmMethodInfo(Name = "setApprovalForAll", View = false)]
		public Task<Transaction> SetApprovalForAll([EvmParameterInfo(Type = "address", Name = "operator")] EvmAddress @operator, Boolean approved)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<Transaction>) InvokeMethod(method, new object[] { @operator, approved });
		}
		
		[EvmMethodInfo(Name = "supportsInterface", View = true)]
		public Task<Boolean> SupportsInterface([EvmParameterInfo(Type = "bytes4", Name = "interfaceId")] Byte[] interfaceId)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<Boolean>) InvokeMethod(method, new object[] { interfaceId });
		}
		
		[EvmMethodInfo(Name = "uri", View = true)]
		public Task<String> Uri([EvmParameterInfo(Type = "uint256", Name = "")] BigInteger @tokenId)
		{
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			return (Task<String>) InvokeMethod(method, new object[] { @tokenId });
		}
		
	}
}
#endif
