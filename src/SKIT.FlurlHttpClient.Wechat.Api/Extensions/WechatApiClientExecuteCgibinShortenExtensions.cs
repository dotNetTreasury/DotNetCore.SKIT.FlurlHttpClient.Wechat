﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinShortenExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/shorturl 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/URL_Shortener.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/qrcode/shorturl.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinShortUrlResponse> ExecuteCgibinShortUrlAsync(this WechatApiClient client, Models.CgibinShortUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "shorturl")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinShortUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/shorten/gen 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/KEY_Shortener.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinShortenGenerateResponse> ExecuteCgibinShortenGenerateAsync(this WechatApiClient client, Models.CgibinShortenGenerateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "shorten", "gen")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinShortenGenerateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/shorten/fetch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/KEY_Shortener.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinShortenFetchResponse> ExecuteCgibinShortenFetchAsync(this WechatApiClient client, Models.CgibinShortenFetchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "shorten", "fetch")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinShortenFetchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
