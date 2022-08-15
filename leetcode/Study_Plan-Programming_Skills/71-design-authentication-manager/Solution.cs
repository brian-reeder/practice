﻿/*
File Name: 
    71-design-authentication-manager/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    August 14, 2022, 17:09

Description:
    There is an authentication system that works with authentication tokens.
    For each session, the user will receive a new authentication token that
    will expire timeToLive seconds after the currentTime. If the token is
    renewed, the expiry time will be extended to expire timeToLive seconds
    after the (potentially different) currentTime.

    Implement the AuthenticationManager class:
        * AuthenticationManager(int timeToLive) constructs the
            AuthenticationManager and sets the timeToLive.
        * generate(string tokenId, int currentTime) generates a new token with
            the given tokenId at the given currentTime in seconds.
        * renew(string tokenId, int currentTime) renews the unexpired token
            with the given tokenId at the given currentTime in seconds. If
            there are no unexpired tokens with the given tokenId, the request
            is ignored, and nothing happens.
        * countUnexpiredTokens(int currentTime) returns the number of unexpired
            tokens at the given currentTime.
        * Note that if a token expires at time t, and another action happens on
            time t (renew or countUnexpiredTokens), the expiration takes place
            before the other actions.

Constraints:
    * 1 <= timeToLive <= 108
    * 1 <= currentTime <= 108
    * 1 <= tokenId.length <= 5
    * tokenId consists only of lowercase letters.
    * All calls to generate will contain unique values of tokenId.
    * The values of currentTime across all the function calls will be strictly
        increasing.
    * At most 2000 calls will be made to all functions combined
*/
public class AuthenticationManager {
    Dictionary<string, int> _tokens;
    int _ttl;
    public AuthenticationManager(int timeToLive) {
        this._tokens = new Dictionary<string, int>();
        this._ttl = timeToLive;
    }
    
    public void Generate(string tokenId, int currentTime) {
        this._tokens[tokenId] = currentTime + this._ttl;
    }
    
    public void Renew(string tokenId, int currentTime) {
        if(this._tokens.ContainsKey(tokenId))
            if(currentTime < this._tokens[tokenId])
                this._tokens[tokenId] = currentTime + this._ttl;
    }
    
    public int CountUnexpiredTokens(int currentTime) {
        var count = 0;
        foreach(var val in this._tokens.Values)
            if(currentTime < val)
                count++;
        
        return count;
    }
}