using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using JWT;
using JWT.Algorithms; //加密算法
using JWT.Builder;
using JWT.Exceptions;
using JWT.Serializers;


namespace Common
{
    public class JWTHelper
    {
        private string Key { get; set; } = "bfdhargrtjuykreawtuyjtretryjgafasdgrth";// 这个密钥
        private IJwtAlgorithm algorithm { get; set; }  // 这是 HMACSHA256加密算法
        private IJsonSerializer serializer { get; set; }// 这是JSON序列化工具
        private IBase64UrlEncoder urlEncoder { get; set; } // 这是BASE64编码工具
        private IDateTimeProvider provider { get; set; }// 时间提供器  用来提供 格式一致的时间
        private IJwtValidator validator { get; set; }

        public JWTHelper()
        {
             Key = "klklergsflergldsarertlherdsigerklgld";// 这个密钥
             algorithm  = new HMACSHA256Algorithm(); // 这是 HMACSHA256加密算法
             serializer  = new JsonNetSerializer();// 这是JSON序列化工具
             urlEncoder  = new JwtBase64UrlEncoder(); // 这是BASE64编码工具
             provider  = new UtcDateTimeProvider(); // 时间提供器
             validator  = new JwtValidator(serializer, provider); // 令牌校验器，用来验证有效期和签名
        }
        public string GetToken(Dictionary<string, object> payload,int expSeconds)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // or use JwtValidator.UnixEpoch
            var now = provider.GetNow();
            payload["exp"] = Math.Round((now - unixEpoch).TotalSeconds) + expSeconds;// exp 有效期
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);//  JWT加密工具
            var token = encoder.Encode(payload, Key); // 加密生成TOKEN
            return token;
        }
        // 解密
        public string GetPayload(string token) 
        {
            try
            {
                IJwtDecoder decoder = new JwtDecoder(serializer,validator,  urlEncoder, algorithm); // 创建解密工具
                var json = decoder.Decode(token, Key, verify: true);//token 中的载体的 JSON 格式字符串
                return json;  // payload
            }
            catch (TokenExpiredException)
            {
                Console.WriteLine("Token has expired");
                return null;
            }
            catch (SignatureVerificationException)
            {
                Console.WriteLine("Token has invalid signature");
                return null;
            }
        }
    }
}