﻿using System.Web.Http;
using System.Web.Http.Controllers;

namespace Lenic.Web.WebApi.Services.ParameterBindings
{
    /// <summary>
    /// Json Body 字符串格式数值绑定特性
    /// </summary>
    public class JsonBodyParameterBindingAttribute : ParameterBindingAttribute
    {
        #region Override Members

        /// <summary>
        /// 获取参数绑定。
        /// </summary>
        /// <param name="parameter">参数说明。</param>
        /// <returns>参数绑定。</returns>
        public override HttpParameterBinding GetBinding(HttpParameterDescriptor parameter)
        {
            parameter.ParameterBinderAttribute = this;

            return new JsonBodyParameterBinding(parameter);
        }

        #endregion Override Members
    }
}